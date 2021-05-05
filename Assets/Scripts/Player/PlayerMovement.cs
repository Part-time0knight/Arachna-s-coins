using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    public const float ROTATE_MULTIPLIER = 20f;
    protected override void Init()
    {
        Debug.Log("Класс передвежения игрока");
    }

    protected override void Rotate()
    {
        Vector3 rotate = Vector3.zero;
        rotate.y = vector.x * ROTATE_MULTIPLIER * speed;
        body.transform.Rotate(rotate * Time.deltaTime);
    }
}
