using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Equipment
{
    public string weaponName;
    public string animation;
}

public class GetEquippedScene : MonoBehaviour
{

    public AudioClip sceneSong;

    public string name = "Metalbot";
    public Text text;

    public Animator playerAnimator;

    public Equipment[] equipments;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        if(MusicPlayer.instance != null)
            MusicPlayer.instance.PlaySong(sceneSong);

        if(SceneController.instance != null)
        {
            SceneController.instance.StartScene();
        }

        yield return new WaitForSeconds(1);

        string name = "metalbot";
        string getEquipped = "get equipped";
        string with = "with";

        for (int i = 0; i < name.Length; i++)
        {
            text.text += name[i];
            yield return new WaitForSeconds(0.1f);
        }
        text.text += "\n";
        for (int i = 0; i < getEquipped.Length; i++)
        {
            text.text += getEquipped[i];
            yield return new WaitForSeconds(0.1f);
        }
        text.text += "\n";
        for (int i = 0; i < with.Length; i++)
        {
            text.text += with[i];
            yield return new WaitForSeconds(0.1f);
        }
        text.text += "\n";
        playerAnimator.Play(equipments[GameManager.instance.boss].animation);
        yield return new WaitForSeconds(2f);
        playerAnimator.Play(equipments[GameManager.instance.boss].weaponName);
        string weapon = equipments[GameManager.instance.boss].weaponName;

        for (int i = 0; i < weapon.Length; i++)
        {
            text.text += weapon[i];
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(2f);
        SceneController.instance.LoadScene("Menu");

    }

   
}
