using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>0;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = input.GetAxis("Horizontal");
        float moveVertical = input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        rb.AddForce(movement * speed);
    
    }
}
