using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anm : MonoBehaviour
{
    public Animator playerAnimator;

    public string animWalk;
    public string animIdle;
    public string animAtk;

    public KeyCode walkKey;
    public KeyCode idleKey;
    public KeyCode AtkKey;


    void Update()
    {
        if (Input.GetKeyDown(walkKey))
        {
            playerAnimator.Play(animWalk);
        }
        if (Input.GetKeyDown(idleKey))
        {
            playerAnimator.Play(animIdle);
        }
        if(Input.GetKeyDown(AtkKey))
        {
            playerAnimator.Play(animAtk);
        }
    }
}
