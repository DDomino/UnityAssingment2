using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObject : MonoBehaviour
    

{
    public float destroyDelay;
    public GameObject Sphere;
  
    void Update()
    {
        Object.Destroy(Sphere, destroyDelay);
        
    }
}
