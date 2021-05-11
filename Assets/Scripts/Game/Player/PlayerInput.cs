using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //--
    private float hAxis = 0f;
    public float HAxis
    {
        get { return hAxis; }
    }
    //--
    private float vAxis = 0f;
    public float VAxis
    {
        get
        { return vAxis; }
    }
    //--

    private void Update()
    {
        hAxis = GameInput.Horizontal;
        vAxis = GameInput.Vertical;
    }
}
