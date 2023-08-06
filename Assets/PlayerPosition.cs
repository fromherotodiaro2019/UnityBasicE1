using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    
    List<GameObject> minions;
    public GameObject minionPrefab;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;
   
    private void Start()
    {
        this.minions = new List<GameObject>();
    }
    void Update()
    {
        this.Spawn();

        CheckMinionDead();

    }


    void Spawn()
    {
        // Giai thuat tao delay
        //this.spawntimer = time.deltatime;
        //if (this.spawntimer < spawndelay) return;
        //this.spawntimer = 0;

        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < spawnDelay)
        { 
            return;
        } 
        this.spawnTimer = 0;
        //---------------------------------------
        if (this.minions.Count >= 7)
        {
            return;
        }
        int index = this.minions.Count + 1;
        GameObject minion = Instantiate(this.minionPrefab);
        minion.name = "Boom" + index;
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
            if (minion == null) this.minions.RemoveAt(i);
        }
    }
}