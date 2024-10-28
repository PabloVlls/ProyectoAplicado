using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectionText : MonoBehaviour
{
    public TMP_InputField inputText;

    public TMP_Text journalyText;
    public GameObject popUpPanel;
    public GameObject journalyPanel;
    public TMP_Text popUpText;
    public Image lightSignal;
    public GameObject saveButton;

    private void Awake()
    {
        lightSignal.color = Color.red;
        popUpPanel.SetActive(false);
    }

    private void Update()
    {
        if (journalyText.text.Length < 4)
        {
            lightSignal.color = Color.red;
            saveButton.SetActive(false);
        }
        if (journalyText.text.Length >= 4)
        {
            lightSignal.color = Color.green;
            saveButton.SetActive(true);
        }
    }

    public void Save()
    {
        //PlayerPrefs.SetString("journaly1", inputText.text);
        popUpText.text = journalyText.text;
        popUpPanel.SetActive(true);
        journalyPanel.SetActive(false);
    }
}
