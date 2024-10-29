using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlQ : MonoBehaviour
{
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;
    public GameObject question5;
    public GameObject question6;
    public GameObject question7;
    public GameObject question8;
    public GameObject question9;
    public GameObject question10;

    private void Awake()
    {
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        question6.SetActive(false);
        question7.SetActive(false);
        question8.SetActive(false);
        question9.SetActive(false);
        question10.SetActive(false);
    }
}
