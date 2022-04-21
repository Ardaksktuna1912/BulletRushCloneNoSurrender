using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shootPoint;
    RaycastHit hitb;
    void Start()
    {

    }


    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitb, 20f))
        {


            if (hitb.collider.gameObject.tag == "smallEnemy" || hitb.collider.gameObject.tag == "bigEnemy")
            {

                GameObject tempBullet = Instantiate(bullet, shootPoint.transform.position, Quaternion.identity);
                tempBullet.GetComponent<Bulletcontrol>().hit = hitb.point;

            }
        }



    }
}
