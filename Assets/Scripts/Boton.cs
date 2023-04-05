using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
   public GameObject bola;
   private float fuerza = 80.0f;
   private float aceleracion = 10.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if( Input.GetKeyDown( KeyCode.Space ) )
    {
        rb.AddForce(transform.forward * fuerza, ForceMode.VelocityChange);
    }
    
    }
}

