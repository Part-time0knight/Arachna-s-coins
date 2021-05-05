using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : Movement
{
    private float speedRotation;
    private int dir;
    public const float SPEED_ROTATION_MAX = 100f;
    public const float SPEED_ROTATION_MIN = 10f;
    protected override void Init()
    {
        speedRotation = Random.Range(SPEED_ROTATION_MIN, SPEED_ROTATION_MAX);
        speedRotation = SPEED_ROTATION_MAX;
        dir = Random.Range(0, 2);
    }
    protected override void Rotate()
    {
        if (ground)
        {
            Vector3 angle = new Vector3(0f, speedRotation, 0f) * Time.deltaTime;
            body.transform.Rotate(angle);
        }
    }
}
