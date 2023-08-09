using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    // [SerializeField]
    protected EnemyCtrl enemyCtrl;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReveive = collision.GetComponent<DamageReceiver>();
        damageReveive.Receiver(1);

        this.enemyCtrl.despawner.Despawn();

        Debug.Log(collision.name);
    }
}
