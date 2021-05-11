using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePanel : PanelController
{
    protected override void Init()
    {
        _pausePanel = gameObject;
        pauseImage = GetComponent<Image>();
    }
    public override void Show(EndFunction end)
    {
        animator.SetBool("FadeIn", true);
        animator.SetBool("FadeOut", false);
        this.end = end;
    }
    public override void Hide(EndFunction end)
    {
        animator.SetBool("FadeIn", false);
        animator.SetBool("FadeOut", true);
        this.end = end;
    }
}
