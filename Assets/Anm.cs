using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anm : MonoBehaviour
{
    public Animator playerAnimator;

    public string animWalk;
    public string animIdle;

    public KeyCode walkKey;
    public KeyCode idleKey;


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

    }
}
