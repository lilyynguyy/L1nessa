using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] trashPrefabs;
    public GameObject[] buttonsList;
    private float spawnZ = 9.9f;
    public int seconds = 1;

    private float spawnRangeX = 10;


    private float delay = 1.0f;
    public float difficulty = 0.3f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SpawnTrash();
        }
    }
    // Spawns animal by pressing Left Shift (mostly for testing)
    void SpawnTrash()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 3.37f, Random.Range(-spawnZ, spawnZ));
        //Randomly generate an animal index between 0 and 2
        int trashIndex = Random.Range(0, trashPrefabs.Length);
        Instantiate(trashPrefabs[trashIndex], spawnPos, //Spawns animal at random spawnPos
            trashPrefabs[trashIndex].transform.rotation);
    }
    /*
    public void StartGame(float diff)
    {
        difficulty = diff;
        StartCoroutine("Begin"); // starts IEnumerator Begin procedure
        foreach (GameObject g in buttonsList)
        {
            g.SetActive(false); // Hides Button from uer view
        }

    }
    */
    private IEnumerator Begin()
    {

        yield return new WaitForSeconds(seconds); // waits for input amount of seconds before spawns the animals repeatedly
        InvokeRepeating("SpawnTrash", delay, difficulty);
    }

}
