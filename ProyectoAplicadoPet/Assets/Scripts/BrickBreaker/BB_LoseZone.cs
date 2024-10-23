using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BB_LoseZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            FindObjectOfType<BB_GameManager>().LoseLive();
        }
    }
}
