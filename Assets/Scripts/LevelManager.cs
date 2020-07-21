using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public GameObject player;
    public GameObject playerIntro;
    public GameObject introText;
    public AudioClip stageSong;
    public AudioClip bossFightSong;
    public AudioClip victorySong;

    public bool checkPoint;
    public Transform checkpointPos;
    public GameObject checkpointCamera;

    public Weapon levelWeapon;

    public UnityEvent OnStartBossFight;
    public UnityEvent OnCheckpoint;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    IEnumerator Start()
    {
        if(SceneController.instance != null)
            SceneController.instance.StartScene();
        if(MusicPlayer.instance != null)
            MusicPlayer.instance.PlaySong(stageSong);
        yield return new WaitForSeconds(3f);
        introText.SetActive(false);
        yield return new WaitForSeconds(0.75f);
        playerIntro.SetActive(false);
        player.SetActive(true);
    }

   
    public void SetCheckPoint(bool state)
    {
        checkPoint = state;
    }

    public void Restart()
    {
        player.transform.position = checkpointPos.position;

        player.SetActive(true);

        OnCheckpoint.Invoke();

        Invoke("SetCamera", 2f);
    }

    void SetCamera()
    {
        CamerasController.instance.EnableCamera(checkpointCamera);
        if (MusicPlayer.instance != null)
            MusicPlayer.instance.PlaySong(stageSong);


    }

    public void PlayBossFight()
    {
        if(MusicPlayer.instance != null)
        {
            MusicPlayer.instance.PlaySong(bossFightSong);
            
        }

        Invoke("StartFight", 1f);
    }

    void StartFight()
    {
        OnStartBossFight.Invoke();
    }

    public void FinishLevel()
    {
        GameManager.instance.AddWeapon(levelWeapon);
        StartCoroutine(FinishingLevel());
    }

    IEnumerator FinishingLevel()
    {
        if (MusicPlayer.instance != null)
        {
            MusicPlayer.instance.FadeSong();

        }
        yield return new WaitForSeconds(3f);
        if (MusicPlayer.instance != null)
        {
            MusicPlayer.instance.PlaySong(victorySong);

        }

        if(SceneController.instance != null)
        {
            yield return new WaitForSeconds(5);
            SceneController.instance.LoadScene("GetEquipped");
        }
    }



}
