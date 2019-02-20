using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPointScript : MonoBehaviour
{
    private int count;
    
    private void Start()
    {
        count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("powerUp")) {
            other.gameObject.SetActive(false);
            count ++;
        
        }
    }
    private void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + count);
    }
}
