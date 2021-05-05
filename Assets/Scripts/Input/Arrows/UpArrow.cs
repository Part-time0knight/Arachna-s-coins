using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpArrow : Button
{
    public override void DownButton()
    {
        GameInput.Vertical = 1f;
    }
    public override void UpButton()
    {
        GameInput.Vertical = -0f;
    }
}
