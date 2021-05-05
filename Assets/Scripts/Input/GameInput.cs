using System.Collections;
using System.Collections.Generic;

public static class GameInput
{
    public static float Horizontal { get; set; }
    public static float Vertical { get; set; }
    static GameInput()
    {
        Horizontal = 0f;
        Vertical = 0f;
    }
}
