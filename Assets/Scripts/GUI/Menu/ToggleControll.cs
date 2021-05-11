using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public abstract class ToggleControll : MonoBehaviour
{
    protected Toggle toggle;
    private ButtonSfx buttonSfx;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
        buttonSfx = GetComponent<ButtonSfx>();
        ToggleInit();
    }
    public void ToggleClick()
    {
        ChangeItem();
        if (buttonSfx)
            buttonSfx.Sound();
    }
    protected abstract void ToggleInit();
    protected abstract void ChangeItem();

}
