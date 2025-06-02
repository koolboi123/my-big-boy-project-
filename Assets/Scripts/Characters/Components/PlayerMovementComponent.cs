using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovementComponent : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxSpeed;
     Rigidbody2D rb;
     PlayerInput input;
     [SerializeField] float rotationSpeed = 20; 
     private Vector2 currentMovementDirection;

     private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();
       input = GetComponent<PlayerInput>();
       BindInput();
       animator = GetComponent<Animator>();
       
    }

   

    // Update is called once per frame
    void FixedUpdate()
    {
     rb.AddForce(transform.right * (currentMovementDirection.y * speed), ForceMode2D.Impulse); 
     transform.Rotate(Vector3.forward, currentMovementDirection.x * rotationSpeed * Time.deltaTime);
     float currentspeed = rb.linearVelocity.magnitude;
     if (currentspeed > maxSpeed)
     {
        rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;    
     }

     animator.speed = rb.linearVelocity.magnitude * 0.3f;
     
    }
    void BindInput()
    {
        input.actions["Move"].performed += ctx => currentMovementDirection = ctx.ReadValue<Vector2>();
    }

}


    