using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    float horizontal;
    float vertical;
    Vector3 vec;
    Rigidbody fizik;
     void Start()
    {
        fizik = GetComponent<Rigidbody>();    
    }

    void Update()
    {
        NormalMove();

       
    }
    void NormalMove()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical= Input.GetAxis("Vertical");

        vec = new Vector3(horizontal,0,vertical);
        vec = transform.TransformDirection(vec);

        fizik.position += vec * Time.deltaTime*speed;
    }
   
   
}
