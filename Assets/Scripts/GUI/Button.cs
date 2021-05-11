using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private ButtonSfx buttonSfx;
    public abstract void DownButton();
    public abstract void UpButton();
    private void Awake()
    {
        buttonSfx = GetComponent<ButtonSfx>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        DownButton();
        if (buttonSfx)
            buttonSfx.Sound();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        UpButton();
    }
}
