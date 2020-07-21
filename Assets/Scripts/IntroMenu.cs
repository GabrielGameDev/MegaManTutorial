using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[System.Serializable]
public class IntroText
{
    public string text;
    public float time;
}

public class IntroMenu : MonoBehaviour
{
    public Text text;

    public IntroText[] texts;

    private AudioSource audioSource;
    private bool started;

    IEnumerator Start()
    {
        Cursor.visible = false;

        audioSource = GetComponent<AudioSource>();

        SceneController.instance.StartScene();
        yield return new WaitForSeconds(1);

        for (int i = 0; i < texts.Length; i++)
        {
            text.text = texts[i].text;
            yield return StartCoroutine(FadingText());
            yield return new WaitForSeconds(texts[i].time);
            yield return StartCoroutine(FadingOutText());
        }
    }

    IEnumerator FadingText()
    {
        Color newColor = text.color;
        while (newColor.a < 1)
        {
            newColor.a += Time.deltaTime;
            text.color = newColor;
            yield return null;
        }
    }

    IEnumerator FadingOutText()
    {
        Color newColor = text.color;
        while (newColor.a > 0)
        {
            newColor.a -= Time.deltaTime;
            text.color = newColor;
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
            return;

        if (Keyboard.current.anyKey.isPressed)
        {
            started = true;
            MusicPlayer.instance.FadeSong();
            SceneController.instance.LoadScene("Menu");
            audioSource.Play();
        }
    }
}
