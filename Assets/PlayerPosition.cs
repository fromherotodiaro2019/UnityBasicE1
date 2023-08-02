using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    float playerPosX;
    List<GameObject> minions;
    // Update is called once per frame
    private void Start()
    {
        this.minions = new List<GameObject>();
    }
    void Update()
    {
        this.playerPosX = this.transform.position.x;

        int spawnLocation = 7;

        if (this.playerPosX >= spawnLocation)
        {
            this.Spawn();
        }
        else
        {
            this.NotSpawn();
        }

    }


    void Spawn()
    {
        Debug.Log("Spawn");

        if (this.minions.Count >= 7)
        {
            return;
        }
        int index = this.minions.Count + 1;
        GameObject minion = new GameObject("Minion#" +index);
        this.minions.Add(minion);
    }

    void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }

}
