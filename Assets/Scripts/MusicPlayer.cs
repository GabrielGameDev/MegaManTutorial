using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public static MusicPlayer instance;

    private AudioSource audioSource;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySong(AudioClip song)
    {
        StopAllCoroutines();
        audioSource.volume = 0.5f;
        audioSource.clip = song;
        audioSource.Play();
    }

    public void Stop()
    {
        audioSource.Stop();
    }

    public void FadeSong()
    {
        StartCoroutine(Fading());
    }

    IEnumerator Fading()
    {
        
        while (audioSource.volume > 0)
        {
            audioSource.volume -= Time.deltaTime / 2;
            yield return null;
        }
    }
}
