using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class ChangingBody : MonoBehaviour
{
    public GameObject panelOptionBody;

    public SpriteRenderer body;
    public Image squareBodyDisplay;

    public Sprite[] optionSpritesBody;
    
    public int whatBody = 1;

    private void Update()
    {
        squareBodyDisplay.sprite = body.sprite;

        for (int i = 0; i < optionSpritesBody.Length; i++)
        {
            if (i == whatBody)
            {
                body.sprite = optionSpritesBody[i];
            }
        }
    }

    public void ChangePanelState(bool state)
    {
        panelOptionBody.SetActive(state);
    }

    public void ChangeBodySprite(int index)
    {
        whatBody = index;
    }
}
