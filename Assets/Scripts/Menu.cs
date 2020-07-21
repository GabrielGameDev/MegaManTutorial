using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;


public class Menu : MonoBehaviour
{
    public Sprite selection;
    public Sprite nonSelection;
    public StageSelect currentSelect;
    
    public AudioClip menuSong;

    AudioSource audioSource;
    bool confirmed;

    private void Start()
    {
        SceneController.instance.StartScene();
        MusicPlayer.instance.PlaySong(menuSong);
        audioSource = GetComponent<AudioSource>();
        Select(currentSelect);
    }

    void Select(StageSelect newStageSelect)
    {
        if (confirmed)
            return;

        currentSelect.selection.sprite = nonSelection;
        currentSelect = newStageSelect;
        currentSelect.selection.sprite = selection;
    }

    public void OnConfirm()
    {
        if (confirmed)
            return;

        confirmed = true;
        audioSource.Play();
        GameManager.instance.levelSelected = currentSelect.scene;
        GameManager.instance.boss = currentSelect.boss;
        MusicPlayer.instance.FadeSong();
        SceneController.instance.LoadScene("Load");
    }

   public void OnUp()
   {
        if(currentSelect.up != null)
        {
            Select(currentSelect.up);
        }
   }

    public void OnDown()
    {
        if (currentSelect.down != null)
        {
            Select(currentSelect.down);
        }
    }

    public void OnLeft()
    {
        if (currentSelect.left != null)
        {
            Select(currentSelect.left);
        }
    }

    public void OnRight()
    {
        if (currentSelect.right != null)
        {
            Select(currentSelect.right);
        }
    }

}
