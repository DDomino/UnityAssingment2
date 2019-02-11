using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawnbullet : MonoBehaviour
{
    void OnEnable()
    {
        Invoke("ReloadBullet", 1f);
    }

    void ReloadBullet()

    {
        print("Fired bullet");
        gameObject.SetActive(false);
     }


    void OnDisable()
    {
        CancelInvoke();
    }
}

