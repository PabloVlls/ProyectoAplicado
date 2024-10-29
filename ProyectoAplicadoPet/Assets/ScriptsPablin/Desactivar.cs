using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desactivar : MonoBehaviour
{
    public GameObject warningImg;
    void Start()
    {
        StartCoroutine(DesactivarImagen());
    }

    IEnumerator DesactivarImagen()
    {
        yield return new WaitForSeconds(7f);
        warningImg.SetActive(false);
    }
}
