using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    public AudioSource audioData;
    // Start is called before the first frame update
    public void PlaySound()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("Playing");
        
    }

    // Sources: https://docs.unity3d.com/ScriptReference/AudioSource.Play.html
}
