using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TF_ENUMS;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UIElements;

public class Slime : MonoBehaviour
{
    public SlimeData slimeData;
    public StateSlime state = StateSlime.None;
    [SerializeField] float stopDistance = 1.0f;

    [Header("Atributes Settings")]
    public SlimeWorld SlimeWorld;
    public SlimeType SlimeType;
    public int health;
    public float speed;

    [Header("Attacks Settings")]
    public Weapon weapon;
    public WeaponType weaponType;
    public float detectRange;
    public bool isAttacking;
    public bool activeSpecial;

    [Header("Targets")]
    public Transform currentTarget;
    public Transform myTarget;
    [SerializeField] private bool drawRange = true;




    // Start is called before the first frame update
    void Start()
    {
        InitializeSlime();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case StateSlime.Walk:
                MoveTarget();
                break;
            case StateSlime.Attack:
                break;
            case StateSlime.S_Attack:
                break;
            case StateSlime.Die:
                break;
            default:
                break;
        }

        
    }


    void OnDrawGizmos()
    {
        if (!drawRange) return;   
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectRange);
    }
    public void MoveTarget()
    {

        float distance = Vector3.Distance(transform.position,currentTarget.position);

        if (distance > detectRange) 
        {
            Vector3 newPos = transform.position;
            float deltaSpeed = speed * Time.deltaTime;
            newPos.x = Mathf.MoveTowards(newPos.x, currentTarget.position.x , deltaSpeed);
            transform.position = newPos;

            
        }

        else
        {
            state = StateSlime.Attack;
        }
        

       
    }

    public void FindTarget()
    {
        myTarget = GameObject.FindWithTag("BaseEnemy").transform;
        currentTarget = myTarget;
    }

    public void AssignWeapon()
    {
        WeaponStatsInitializer.Initialize(weapon,slimeData);
        weapon.spriteRenderer.sprite = slimeData.WeaponData.WeaponModel;
    }

    public void InitializeSlime()
    {
        StatsInitializer.Initialize(this, slimeData);
        FindTarget();
        AssignWeapon();
        state = StateSlime.Walk;
        
    }
}
