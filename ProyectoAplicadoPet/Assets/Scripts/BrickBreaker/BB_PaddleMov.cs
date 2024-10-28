using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Unity.UI;

public class BB_PaddleMov : MonoBehaviour
{
    public new Rigidbody2D rigidbody 
    { 
        get; 
        private set; 
    }

    public Vector2 direction;

    public float speed = 30f;

    public float maxBounceAngle = 75f;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isMovingLeft)
        {
            direction = Vector2.left;
        }
        else if (isMovingRight)
        {
            direction = Vector2.right;
        }
        else
        {
            direction = Vector2.zero;
        }
        

    }

    public void MoveLeft()
    {
        isMovingLeft = true;
    }

    public void StopMoveLeft()
    {
        isMovingLeft = false;
    }

    public void MoveRight()
    {
        isMovingRight = true;
    }

    public void StopMoveRight()
    {
        isMovingRight = false;
    }


    private void FixedUpdate()
    {
        if(this.direction != Vector2.zero)
        {
            this.rigidbody.AddForce (this.direction * this.speed);
        }
        

    }

    public void ResetPaddle()
    {
        this.transform.position = new Vector2 (0f, this.transform.position.y);
        this.rigidbody.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BB_Ball ball = collision.gameObject.GetComponent<BB_Ball>();

        if(ball != null) 
        {
            Vector3 paddlePosition = this.transform.position;
            Vector2 contactPoint = collision.GetContact(0).point;

            float offset = paddlePosition.x - contactPoint.x;
            float paddleWidth = collision.otherCollider.bounds.size.x / 2;

            float currentAngle = Vector2.SignedAngle(Vector2.up, ball.rigidbody.velocity);
            float bounceAngle = (offset / paddleWidth) * this.maxBounceAngle;
            float newAngle = Mathf.Clamp(currentAngle + bounceAngle,-this.maxBounceAngle, this.maxBounceAngle);

            Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
            ball.rigidbody.velocity = rotation * Vector2.up * ball.rigidbody.velocity.magnitude;
        }
    }



}
