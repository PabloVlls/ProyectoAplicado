using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BB_SceneManager : MonoBehaviour
{
    public void BackMain()
    {
        SceneManager.LoadScene("BB_Main");
    }

    public void BackGame()
    {
        SceneManager.LoadScene("JuegoCompleto");
    }
}
