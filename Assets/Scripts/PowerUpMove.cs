using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMove : MonoBehaviour
{
    float posX;
    float posY;
    float posZ;

    Vector3 aPosition;
    Vector3 bPosition;
    public float lerpValue;
    bool atPosB;


    void Start()
    {



        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        aPosition = transform.position;
        bPosition = new Vector3(posX + 100, posY, posZ);
        atPosB = false;
       
      
        

    }

    // Update is called once per frame
    void Update()
    {
       



    }
}