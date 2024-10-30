using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
public class UIAudioManager : MonoBehaviour
{
    public static UIAudioManager instance;
    
    public EventReference click1Forward;
    public EventReference click2Back;
    public EventReference escritura;

    private void Awake()
    {
        instance = this;
    }

    public void Click1_Oneshot()
    {
        RuntimeManager.PlayOneShot(click1Forward);
    }
    public void Click2_Oneshot()
    {
        RuntimeManager.PlayOneShot(click2Back);
    }
    public void Escritura_Oneshot()
    {
        RuntimeManager.PlayOneShot(escritura);
    }
}
