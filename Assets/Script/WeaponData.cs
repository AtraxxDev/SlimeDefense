using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TF_ENUMS;

[CreateAssetMenu(fileName ="WeaponType",menuName ="Scriptable Objects/WeaponType")]
public class WeaponData : ScriptableObject
{
    public WeaponType WeaponType;
    public Sprite WeaponModel;
    public int damage = 1;
    public float fireRate = 1.0f;
}
