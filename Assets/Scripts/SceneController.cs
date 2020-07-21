using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{

    public static SceneController instance;

    public Image fadeImage;

    public GameObject loadText;

    private string nextScene;

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
    }

    public void LoadScene(string scene)
    {
        nextScene = scene;
        StartCoroutine(Fading());
        Invoke("LoadNextScene", 1f);
    }

    public void RestartScene()
    {
        LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator Fading()
    {
        Color newColor = fadeImage.color;
        while (newColor.a < 1)
        {
            newColor.a += Time.deltaTime;
            fadeImage.color = newColor;
            yield return null;
        }

        yield return new WaitForSeconds(1);

        if(fadeImage.color.a >= 1)
            loadText.SetActive(true);

    }

    public void StartScene()
    {
        loadText.SetActive(false);
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        Color newColor = fadeImage.color;
        while (newColor.a > 0)
        {
            newColor.a -= Time.deltaTime;
            fadeImage.color = newColor;
            yield return null;
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadSceneAsync(nextScene);
    }

}
