using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImage : MonoBehaviour
{
    [SerializeField ] private AnimationClip idle;
    [SerializeField] private AnimationClip walk;
    [SerializeField] private AnimationClip rotate;
    private Animation anim;
    private void Awake()
    {
        anim = GetComponent<Animation>();
    }
    public void StartWalk()
    {
        anim.Play(walk.name);
    }
    public void StartRotate()
    {
        anim.Play(rotate.name);
    }
    public void StartIdle()
    {
        anim.Play(idle.name);
    }
}
