using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TF_ENUMS;

[CreateAssetMenu(fileName ="SlimeType",menuName ="Scriptable Objects/SlimeType")]
public class SlimeData : SlimeBase
{
    [Header("Atributes Settings")]
    public SlimeWorld SlimeWorld;
    public SlimeType SlimeType;
    public GameObject sprite_Model;
    public int health = 20;
    public float speed;

    [Header("Shop Settings")]
    public int Cost = 1;
    public int hitCoin = 5;

    [Header("Attacks Settings")]
    public WeaponData WeaponData;
    public float detectRange = 0.7f;
    public bool isAttacking;
    public bool activeSpecial;

    [Header("Animations Settings")]
    public AnimationClip Anim_Die;



    public override void S_Attack()
    {
       
    }

}
