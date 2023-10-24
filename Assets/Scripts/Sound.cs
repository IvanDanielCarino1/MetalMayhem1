using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioPlayer;

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "enemy")
        {
            audioPlayer.Play();
        }
    }
    public void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            audioPlayer.Stop();
        }
    }
}
