using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public abstract void DownButton();
    public abstract void UpButton();
    
    public void OnPointerDown(PointerEventData eventData)
    {
        DownButton();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        UpButton();
    }
}
