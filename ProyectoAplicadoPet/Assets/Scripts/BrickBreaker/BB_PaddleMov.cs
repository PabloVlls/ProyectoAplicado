using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BB_PaddleMov : MonoBehaviour
{
    public new Rigidbody2D rigidbody 
    { 
        get; 
        private set; 
    }
    public Vector2 direction { get; private set; }

    public float speed = 30f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            this.direction = Vector2.left; 
        }
        else if(Input.GetKey(KeyCode.D))
        {
            direction = Vector2.right;
        }
        else
        {
            this.direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if(this.direction != Vector2.zero)
        {
            this.rigidbody.AddForce (this.direction * this.speed);
        }
    }



}
