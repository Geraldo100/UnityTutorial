using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float acceleration; 
    public float speed;
    private Rigidbody rb;
    private int count;
    public Text countText;
    public Text WinText;
    public float HorizontalAccel;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        WinText.text = " ";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * HorizontalAccel, 0.0f, moveVertical * acceleration);


        rb.AddForce(movement * speed);
    }
        void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Pickup"))
            {
                other.gameObject.SetActive(false);
                count = count + 1;
            SetCountText();
            }
        }


    void SetCountText()
    {
        countText.text = "count: " + count.ToString();
        if (count >= 12)
            WinText.text = "You win!";
    }
}


