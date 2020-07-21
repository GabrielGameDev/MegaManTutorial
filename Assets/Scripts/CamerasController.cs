using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
	public static CamerasController instance;
	
	public GameObject[] cameras;
	public float freezeTime = 1;

	private void Awake()
	{
		instance = this;
	}

	public void EnableCamera(GameObject camera)
	{
		if (camera.activeInHierarchy)
			return;

		for (int i = 0; i < cameras.Length; i++)
		{
			cameras[i].SetActive(false);
		}

		camera.SetActive(true);

		StartCoroutine(FreezingTime());
	}

	IEnumerator FreezingTime()
	{
		Time.timeScale = 0;

		yield return new WaitForSecondsRealtime(freezeTime);

		Time.timeScale = 1;
	}
}
