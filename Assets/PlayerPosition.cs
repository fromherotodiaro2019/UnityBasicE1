using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    float playerPosX;
    List<GameObject> minions;
    public GameObject minionPrefab;
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

        CheckMinionDead();

    }


    void Spawn()
    {
        Debug.Log("Spawn");

        if (this.minions.Count >= 7)
        {
            return;
        }
        int index = this.minions.Count + 1;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "MinionPrefab" + index;
        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);
        this.minions.Add(minion);
    }

    void CheckMinionDead()
    {
        GameObject minion;
        for (int i = 0; i < this.minions.Count; i++)
        {
            minion = this.minions[i];
            if(minion == null)  this.minions.RemoveAt(i);
        }
    }

    void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }

}
