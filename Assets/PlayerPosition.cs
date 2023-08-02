using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    float playerPosX;
    // Update is called once per frame
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
    }

    void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }

}
