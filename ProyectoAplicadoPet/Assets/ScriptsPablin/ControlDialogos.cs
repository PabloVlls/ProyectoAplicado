using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ControlDialogos : MonoBehaviour
{
    public string mensaje;
    public int numMensaje;
    public Flowchart dialogo;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void MensajeAlegria()
    {
        mensaje = "Alegria";
    }

    public void MensajeDesagrado()
    {
        mensaje = "Desagrado";
    }

    public void MensajeTristeza()
    {
        mensaje = "Tristeza";
    }

    public void Ana()
    {
        numMensaje = 0;
        Debug.Log(mensaje + numMensaje);
        dialogo.SendFungusMessage(mensaje + numMensaje.ToString());
    }

    public void Mimi()
    {
        numMensaje = 1;
        Debug.Log(mensaje + numMensaje);
        dialogo.SendFungusMessage(mensaje + numMensaje.ToString());
    }

    public void Morita()
    {
        numMensaje = 2;
        Debug.Log(mensaje + numMensaje);
        dialogo.SendFungusMessage(mensaje + numMensaje.ToString());
    }

    public void Yurani()
    {
        numMensaje = 3;
        Debug.Log(mensaje + numMensaje);
        dialogo.SendFungusMessage(mensaje + numMensaje.ToString());
    }
}
