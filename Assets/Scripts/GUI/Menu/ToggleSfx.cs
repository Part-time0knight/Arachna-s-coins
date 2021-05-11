using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSfx : ToggleControll
{
    protected override void ToggleInit()
    {
        toggle.isOn = Settings.sfx;
    }
    protected override void ChangeItem()
    {
        Settings.sfx = toggle.isOn;
    }
}
