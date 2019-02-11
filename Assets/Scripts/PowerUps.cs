using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
   public GameObject powerUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           // Destroy(powerUp);

        }
    }


    void OnCollisionEnter(Collision other)
    {
        
    }
}
