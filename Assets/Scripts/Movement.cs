using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    public const float ROTATE_MULTIPLIER = 20f;
    public const float G = -10f;
    private const float HALF_CIRCLE = 180f;
    private CharacterController body;

    private void Awake()
    {
        body = GetComponent<CharacterController>();
    }
    private float AngleToRad( float angle)
    {
        return angle * Mathf.PI / HALF_CIRCLE;
    }
    public void Move(Vector3 vector, float speed)
    {
        Vector3 motion = Vector3.zero;
        Vector3 rotate = Vector3.zero;
        if (body.isGrounded)
        {
            float rad = AngleToRad(transform.eulerAngles.y);
            motion.x = vector.z * Mathf.Sin(rad);
            motion.z = vector.z * Mathf.Cos(rad);
            rotate.y = vector.x * ROTATE_MULTIPLIER * speed;
            motion *= speed;
        }
        else
            motion = new Vector3(0f, G, 0f);
        body.Move(motion * Time.deltaTime);
        body.transform.Rotate(rotate * Time.deltaTime);
    }
}
