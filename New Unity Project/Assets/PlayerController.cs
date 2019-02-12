using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Public variables
    public float walkSpeed;

    //Private variables
    Rigidbody rb;
    Vector3 moveDirection;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //direcional input
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        moveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized;
    }


    void FixedUpdate()
    {
        //call move function
        Move();
    }

    void Move()
    {
        //Rigidbody.velocity takes Vector3 and controls speed and direction of the game object
        Vector3 yVelFix = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = moveDirection * walkSpeed * Time.deltaTime;
        rb.velocity += yVelFix;
    }

    }
//https://www.mvcode.com/lessons/first-person-camera-and-controller-jamie
//https://www.mvcode.com/lessons/first-person-camera-controls-jamie
