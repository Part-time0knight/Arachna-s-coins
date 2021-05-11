using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : PanelController
{
    protected override void Init()
    {
        //инициация
    }
    public override void Show(EndFunction end)
    {
        animator.SetBool("Hide", false);
        animator.SetBool("Show", true);
        this.end = end;
    }
    public void Show()
    {
        Show(null);
    }
    public override void Hide(EndFunction end)
    {

        animator.SetBool("Hide", true);
        animator.SetBool("Show", false);
        this.end = end;
    }
    public void Hide()
    {
        Hide(null);
    }
}
