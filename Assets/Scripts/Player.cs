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
        // Rotate in the movement direction
        float horizontal = Input.GetAxis("Horizontal") * rotateSpeed;
   
        //add force in the direction
        rb.AddForce(new Vector3(horizontal, 0, 0));

        //add force to jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpSpeed);
        }

        transform.right = rb.velocity;
    }
}
