using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class T_EE_OnVideoEnd : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena que quieres cargar

    private VideoPlayer videoPlayer;

    public GameObject videosCanva;


    public GameObject panelTriste;

 

    private void Awake()
    {
        panelTriste.SetActive(false);
    }

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoEnd; // Añade un evento al finalizar
    }

    // Función que se ejecuta cuando el video termina
    void OnVideoEnd(VideoPlayer vp)
    {
        //SceneManager.LoadScene("BB_Main");
        videosCanva.gameObject.SetActive(false);// Carga la escena especificada
        panelTriste.SetActive(true);

    }


}
