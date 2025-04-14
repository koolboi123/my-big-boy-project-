using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovementComponent : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxSpeed;
     Rigidbody2D rb;
     PlayerInput input;

     private Vector2 currentMovementDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();
       input = GetComponent<PlayerInput>();
    }

    void SetMoveDirection(Vector2 dir)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    