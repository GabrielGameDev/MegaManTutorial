using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    public AudioClip loadSong;

    public GameObject[] bosses;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        bosses[GameManager.instance.boss].SetActive(true);
        MusicPlayer.instance.PlaySong(loadSong);
        SceneController.instance.StartScene();
        yield return new WaitForSeconds(8f);
        SceneController.instance.LoadScene(GameManager.instance.levelSelected);
    }

    
}
