using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour
{
    float speed = 350;

    float posX;
    float posY;
    float posZ;
    float targetX = 10f;

    //LerpVærdier
    Vector3 startPosition;
    Vector3 endPosition;
    public float lerpValue;


    float delayTimer = 2f;

    void Start()
    {

        //LerpStart
        startPosition = transform.position;
        endPosition = new Vector3(10, 1, 1);


        
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;

        // InvokeRepeating("moveBasic", 2f, 0.1f);
        //StartCorotine bruges til at kalde "IEnumerable" metoder
        StartCoroutine("moveBasic");
    }

   
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;


        moveLerp();


        //moveBasicTweening();

    }

    void MoveDoTween()
    {
        
    }

    void moveLerp()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, lerpValue);
        lerpValue += 0.01f;
    }

    

    void moveBasicTweening()

    {
      
        posX += (targetX - posX) * +0.1f;
        transform.position = new Vector3(posX, posY, posZ);

    }

    void moveBasic2()
    {
        if (transform.position.x <= 10)
            transform.position = new Vector3(transform.position.x + 0.01f * Time.deltaTime * speed, transform.position.y, transform.position.z);

    }
  

    void Timer()
    {

        //Time.deltaTime i dette tilfælde, er der snak om tidsforskællen mellem update bliver
        //kaldt, altså FPS
        /*delayTimer -= Time.deltaTime; 
        if (delayTimer <= 0) {
            print("it is over anikin");
        }
        */
    }

    //fungere en smule som en lille "tråd", men med yield, skemalægger den koden
    IEnumerable moveBasic()
    {
        while(true)
            {
            yield return new WaitForSeconds(1f);
            print("Invoking");
            yield return new WaitForSeconds(2f);
            print("Invoking");
        }
        //yield return null;
    }

}
