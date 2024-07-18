using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeControl : MonoBehaviour
{
    public List<SlimeData> slimeList = new List<SlimeData>();
    public GameObject slimeObject;
    public Transform spawn;

    public void LoadSlime(SlimeData _slime)
    {
        slimeObject = Instantiate(_slime.sprite_Model,spawn);
    }
}
