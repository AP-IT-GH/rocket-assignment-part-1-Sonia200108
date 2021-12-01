using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MyGameManager;

public class Disapear : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        
       Destroy(gameObject);

    }
}
