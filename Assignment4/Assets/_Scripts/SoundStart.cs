using UnityEngine;
using System.Collections;

public class SoundStart : MonoBehaviour
{
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            audio.Stop();
            audio.Play();
        }
        Debug.Log(audio.time);
    }
}