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

    public float maxBounceAngle = 75f;

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
