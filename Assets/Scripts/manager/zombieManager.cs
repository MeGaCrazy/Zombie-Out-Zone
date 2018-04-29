using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieManager : MonoBehaviour {
    public PlayerHealth playerHealth;
    public GameObject zombie;
    public float spawntime = 3f;
    public Transform[] spawnPoints;


    private void Start()
    {
        InvokeRepeating("Spawn", spawntime, spawntime);
    }




    void Spawn()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(zombie, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
