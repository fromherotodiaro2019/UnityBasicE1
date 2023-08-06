using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Follow();
    }

    void Follow()
    {
        Vector3 distance = this.player.position - transform.position;
        if (distance.magnitude >= 3)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * 3;

            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,targetPoint, 15 * Time.deltaTime);
        }
    }
}
