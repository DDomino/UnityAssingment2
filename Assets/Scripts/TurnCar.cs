using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCar : MonoBehaviour
{
    public GameObject myCar;



    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            flipCar();
                
        }
    }


    void flipCar()
    {
        
           // transform.Translate(0, -5f, 0);
            transform.rotation = Quaternion.identity;
        
    }
}

