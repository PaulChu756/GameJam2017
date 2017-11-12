using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpSpeed = 10;
    public float movementSpeed = 10; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        checkInput();
	}

    void checkInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space key is pressed");
            transform.position += transform.up * jumpSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("D is pressed");
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A is pressed");
            transform.position += -transform.right * movementSpeed * Time.deltaTime;
        }
    }
}
