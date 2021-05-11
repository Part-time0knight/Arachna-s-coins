using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public delegate void EndFunction();
public abstract class PanelController : MonoBehaviour
{
    protected static GameObject _pausePanel;
    public static GameObject pausePanel { get { return _pausePanel; } }
    protected static Image pauseImage;
    protected static GameObject _loadPanel;
    public static GameObject loadPanel { get{ return _loadPanel; } }

    protected Animator animator;
    protected EndFunction end;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        Init();
    }
    protected abstract void Init();
    public abstract void Show(EndFunction end);
    public abstract void Hide(EndFunction end);
    public void SetPause()
    {
        if (pauseImage)
        {
            pauseImage.raycastTarget = true;
        }
    }
    public void UnsetPause()
    {
        if (pauseImage)
            pauseImage.raycastTarget = false;
    }
    public static void Pause(bool pause)
    {
        if (pauseImage)
            pauseImage.raycastTarget = pause;
    }
    public void EndAnim()
    {
        if (end != null)
        {
            end();
        }
    }
}
