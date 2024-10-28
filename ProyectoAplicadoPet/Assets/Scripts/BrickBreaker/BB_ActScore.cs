using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BB_ActScore : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private BB_GameManager gameManager;

    private void Start()
    {
        // Obtener referencia al TextMeshPro y al GameManager
        scoreText = GetComponent<TextMeshProUGUI>();
        gameManager = FindObjectOfType<BB_GameManager>();

        if (gameManager == null)
        {
            Debug.LogError("BB_GameManager no encontrado en la escena.");
        }
    }

    private void Update()
    {
        if (gameManager != null)
        {
            // Actualizar el texto con el valor de maxScore desde BB_GameManager
            scoreText.text = "Puntos: " + gameManager.score;
        }
    }
}
