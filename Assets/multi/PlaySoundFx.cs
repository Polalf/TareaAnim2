using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundFx : MonoBehaviour
{
    public AudioSource audio;
    public void PlayFx(AudioClip clip)
    {
        audio.PlayOneShot(clip);
    }
}
