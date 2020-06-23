using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    public GameObject mole;
    public Transform[] spawnPoints;
    public Vector2 spawnInterval;

    public void StartSpawn()
    {
        StartCoroutine(Spawning());
    }

    public void FinishSpawn()
    {
        StopAllCoroutines();
    }

    IEnumerator Spawning()
    {
        while (true)
        {
            int randomSpawn = Random.Range(0, spawnPoints.Length);
            GameObject newMole = Instantiate(mole, spawnPoints[randomSpawn].position, spawnPoints[randomSpawn].rotation);
            Destroy(newMole, 15f);
            yield return new WaitForSeconds(Random.Range(spawnInterval.x, spawnInterval.y));
        }
    }
}
