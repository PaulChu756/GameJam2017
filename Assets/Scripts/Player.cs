using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpSpeed = 1000;
    public float movementSpeed = 10;
    public float rotateSpeed = 100;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        checkInput();
	}

    void checkInput()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("space key is pressed");
            transform.position += transform.up * jumpSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            //Debug.Log("D is pressed");
            //rb.MoveRotation(rb.rotation + rotateSpeed * Time.fixedDeltaTime);
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("A is pressed");
            //rb.MoveRotation(-rb.rotation + rotateSpeed * Time.fixedDeltaTime);
            transform.position += -transform.right * movementSpeed * Time.deltaTime;
            //transform.Rotate
        }
    }
}
