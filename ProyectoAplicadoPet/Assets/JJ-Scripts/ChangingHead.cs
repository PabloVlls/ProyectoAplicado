using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class ChangingHead : MonoBehaviour
{
    public GameObject panelOptionHead;

    public SpriteRenderer head;
    public Image squareHeadDisplay;

    public Sprite[] optionSpritesHead;
    
    public int whatHead = 1;

    private void Update()
    {
        squareHeadDisplay.sprite = head.sprite;

        for (int i = 0; i < optionSpritesHead.Length; i++)
        {
            if (i == whatHead)
            {
                head.sprite = optionSpritesHead[i];
            }
        }
    }

    public void ChangePanelState(bool state)
    {
        panelOptionHead.SetActive(state);
    }

    public void ChangeHeadSprite(int index)
    {
        whatHead = index;
    }
}
