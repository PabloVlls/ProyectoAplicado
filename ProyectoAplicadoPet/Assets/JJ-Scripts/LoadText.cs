using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    private GameObject journaly1;
    private void Start()
    {
        journaly1 = GameObject.FindGameObjectWithTag("Journaly1");
        journaly1.GetComponent<TextMeshPro>().text = PlayerPrefs.GetString("journaly1");
    }
}
