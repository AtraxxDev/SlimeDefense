using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public int cardIndex;

    private SlimeControl slimeControl;

    void Start()
    {
        slimeControl = FindObjectOfType<SlimeControl>();
        GetComponent<Button>().onClick.AddListener(OnClickCard);
    }

    public void OnClickCard()
    {
        if (slimeControl != null && slimeControl.slimeList.Count > cardIndex)
        {
            slimeControl.LoadSlime(slimeControl.slimeList[cardIndex]);
        }
    }
}
