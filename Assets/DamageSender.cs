using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReveive = collision.GetComponent<DamageReceiver>();
        damageReveive.Receiver(1);
        Debug.Log(collision.name);
    }
}
