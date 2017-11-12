using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpSpeed = 10;
    public float movementSpeed = 10;
    public float rotateSpeed = 100;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        checkInput();
	}

    void checkInput()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("space key is pressed");
            //transform.position += transform.up * jumpSpeed * Time.deltaTime;
            rb.AddForce(transform.up * jumpSpeed);
        }

        if(Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D is pressed");
            //rb.MoveRotation(rb.rotation + rotateSpeed * Time.fixedDeltaTime);
            rb.AddForce(transform.right * movementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A is pressed");
            //rb.MoveRotation(-rb.rotation + rotateSpeed * Time.fixedDeltaTime);
            rb.AddForce(-transform.right * movementSpeed);
        }
    }
}
