using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TF_ENUMS{
    
    public enum StateSlime
    {
        None,
        Walk,
        Attack,
        S_Attack,
        Die
    }
    public enum SlimeType
    {
        None,
        Warrior,
        Archer,
        Tank,
        Tower
    }
    public enum SlimeWorld
    {
        None,
        World_1
    }


    public enum WeaponType
    {
        None,
        Sword,
        Archer,
        Shield,
        CrossBow

    }

    public interface IDamagable
    {
        public void Damage();
    }



}

public static class StatsInitializer
{
    public static void Initialize(Slime slime,SlimeData _data)
    {
        slime.SlimeWorld = _data.SlimeWorld;
        slime.SlimeType = _data.SlimeType;
        slime.weaponType = _data.WeaponData.WeaponType;
        slime.health = _data.health;
        slime.speed = _data.speed;
        slime.detectRange = _data.detectRange;
        slime.isAttacking = _data.isAttacking;
        slime.activeSpecial = _data.activeSpecial;
    }

}

public static class WeaponStatsInitializer
{
    public static void Initialize(Weapon weapon, SlimeData _data)
    {
        weapon.WeaponType = _data.WeaponData.WeaponType;
        weapon.WeaponModel = _data.WeaponData.WeaponModel;
        weapon.damage = _data.WeaponData.damage;
        weapon.fireRate = _data.WeaponData.fireRate;
    }

}


