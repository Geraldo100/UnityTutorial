using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float acceleration; 
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical * acceleration);


        rb.AddForce(movement * speed);
    }
        void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Pickup"))
            {
                other.gameObject.SetActive(false);
            }
        }
        

    
}


