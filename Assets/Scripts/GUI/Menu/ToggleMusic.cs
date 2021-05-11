using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMusic : ToggleControll
{
    protected override void ToggleInit()
    {
        toggle.isOn = Settings.music;
        Debug.Log(Settings.music);
    }
    protected override void ChangeItem()
    {
        Settings.music = toggle.isOn;
    }
}
