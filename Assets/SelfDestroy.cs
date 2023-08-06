using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDeytroy : MonoBehaviour
{
    
    void Start()
    {
        Invoke("Destroy", 12f);
    }

    void Destroy( )
    {
        Destroy(gameObject);
    }

}
