using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BB_Ball : MonoBehaviour
{
    public new Rigidbody2D rigidbody;


    public float speed = 500f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        this.transform.position = new Vector2(0f, -1f);
        this.rigidbody.velocity = Vector2.zero;

        Invoke(nameof(SetRandomTrajectory), 2f);
    }

    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        this.rigidbody.AddForce(force/*.normalized*/ * this.speed);
    }
    
    public void SetFastTime()
    {
        Time.timeScale = 2f; // Cambia a la velocidad deseada, 2 es el doble de rápido.
    }

    public void SetNormalTime()
    {
        Time.timeScale = 1f; // Regresa la velocidad del tiempo a la normalidad.
    }
}
