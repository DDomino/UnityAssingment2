using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject enemy;


    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "bullet") {
            Destroy(enemy);
            
        }
    }
}
