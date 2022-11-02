using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anm : MonoBehaviour
{
    public Animator playerAnimator;

    public string animRun;
    public string animIdle;
    public string animAtk;
    public string animJump;
    public string animExtra;
    

    public KeyCode RunKey;
    public KeyCode IdleKey;
    public KeyCode AtkKey;
    public KeyCode JumpKey;
    public KeyCode ExtraKey;


    void Update()
    {
        if (Input.GetKeyDown(RunKey))
        {
            playerAnimator.Play(animRun);
        }
        if (Input.GetKeyDown(IdleKey))
        {
            playerAnimator.Play(animIdle);
        }
        if(Input.GetKeyDown(AtkKey))
        {
            playerAnimator.Play(animAtk);
        }        
        if(Input.GetKeyDown(JumpKey))
        {
            playerAnimator.Play(animJump);
        }        
        if(Input.GetKeyDown(ExtraKey))
        {
            playerAnimator.Play(animExtra);
        }
        
    }
}
