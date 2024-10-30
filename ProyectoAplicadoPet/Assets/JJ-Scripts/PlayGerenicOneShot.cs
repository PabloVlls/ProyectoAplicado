using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class PlayGerenicOneShot : MonoBehaviour
{
    public EventReference soundEvent;
    public EventReference soundEvent1;

    public void Click1_PlayOneShotEvent()
    {
        RuntimeManager.PlayOneShot(soundEvent);
    }
    public void Click2_PlayOneShotEvent()
    {
        RuntimeManager.PlayOneShot(soundEvent1);
    }
}
