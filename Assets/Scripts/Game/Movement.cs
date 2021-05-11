using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public abstract class Movement : MonoBehaviour
{
    public const float G = -10f;
    public bool ground
    {
        get
        {
            if (body)
                return body.isGrounded;
            else
                return false;
        }
    }
    protected const float HALF_CIRCLE = 180f;
    protected CharacterController body;
    protected Vector3 vector = Vector3.zero;
    protected float speed = 0f;

    private void Awake()
    {
        body = GetComponent<CharacterController>();
        Init();
    }
    protected abstract void Init();
    protected abstract void Rotate();
    protected float AngleToRad( float angle)
    {
        return angle * Mathf.PI / HALF_CIRCLE;
    }
    public void Move(Vector3 vector, float speed)
    {
        this.vector = vector;
        this.speed = speed;
        Vector3 motion = Vector3.zero;
        if (ground)
        {
            float rad = AngleToRad(transform.eulerAngles.y);
            motion.x = vector.z * Mathf.Sin(rad);
            motion.z = vector.z * Mathf.Cos(rad);
            motion *= speed;
        }
        else
            motion = new Vector3(0f, G, 0f);
        body.Move(motion * Time.deltaTime);
        Rotate();
    }

}
