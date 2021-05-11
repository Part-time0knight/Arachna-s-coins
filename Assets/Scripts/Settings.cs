using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Settings
{
    public static bool sfx { get; set; }
    public static bool music { get; set; }
    static Settings()
    {
        sfx = true;
        music = true;
    }
}
