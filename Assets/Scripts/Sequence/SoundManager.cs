using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public AudioClip audioClip_Next;
   public AudioClip audioClip_Error;
   public AudioSource audioSource;

    public void play_Next(){
        audioSource.PlayOneShot(audioClip_Next);
    }
    public void play_Error(){
        audioSource.PlayOneShot(audioClip_Error);
    }
}
