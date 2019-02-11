using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody bullet;
    public float bulletSpeed;

    public int pooledAmount;
    List<Rigidbody> bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<Rigidbody>();
        for (int i = 0; i < pooledAmount; ++i)
        {
            Rigidbody obj = (Rigidbody)Instantiate(bullet);
            obj.gameObject.SetActive(false);
            bullets.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
           Fire();
        }

    }


    void Fire()
    {

        for (int i = 0; i < bullets.Count; ++i)
        {
            if (!bullets[i].gameObject.activeInHierarchy)
            {

                //  Rigidbody newBullet = (Rigidbody)Instantiate(bullets[i], transform.position, Quaternion.identity);
                bullets[i].transform.position = transform.position;
                bullets[i].velocity = transform.forward * bulletSpeed;
                bullets[i].gameObject.SetActive(true);
                break;
           
            }
        }

    }
}
    



    

