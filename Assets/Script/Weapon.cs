using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TF_ENUMS;

public class Weapon : MonoBehaviour
{
    [Header("Data")]
    public SpriteRenderer spriteRenderer;


    [Space(3)]
    [Header("Stats")]
    public WeaponType WeaponType;
    public Sprite WeaponModel;
    public int damage;
    public float fireRate;

    void Start()
    {
        
    }

    

}
