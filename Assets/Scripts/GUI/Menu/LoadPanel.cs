using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPanel : PanelController
{
    private RectTransform position;
    protected override void Init()
    {
        _loadPanel = gameObject;
        position = GetComponent<RectTransform>();
    }
    public override void Show(EndFunction end)
    {
        position.anchoredPosition = Vector2.zero;
        this.end = end;
    }
    public override void Hide(EndFunction end)
    {
        position.anchoredPosition = new Vector2 (0f, 10000f);
        this.end = end;
    }
}
