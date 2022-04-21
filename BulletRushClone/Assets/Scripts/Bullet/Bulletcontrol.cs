using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletcontrol : MonoBehaviour
{
    public Vector3 hit;
    public int hiz;


    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce((hit - this.transform.position).normalized * hiz);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Bulletremove();
    }
    void Bulletremove()
    {
        Destroy(this.gameObject, 0.4f);
    }

}
