using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftArrow : Button
{
    public override void DownButton()
    {
        GameInput.Horizontal = -1f;
    }
    public override void UpButton()
    {
        GameInput.Horizontal = 0f;
    }
}
