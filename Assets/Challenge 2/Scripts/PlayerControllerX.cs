using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnRate = 1; // time a player wait to spawn a new dog
    private float nextSpawn = 0; //time since start after which player can spawn again



    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time pass send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate; //This will reset the next spawn to current Time + spawn rate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
