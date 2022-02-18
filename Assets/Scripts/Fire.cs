using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] GameObject weapons,begin;
    private GameObject weaponsParent;
    private Animator objectAnimator;
    private AttackWay attackway;

    private void Start()
    {
        objectAnimator = GetComponent<Animator>();
        SetAttackWay();
    }
    private void Update()
    {
        if (AttackObjetIsWay())
        {
            objectAnimator.SetBool("isAttack",true);
        }
        else
        {
            objectAnimator.SetBool("isAttack",false);
        }
    }

    void SetAttackWay()
    {
        AttackWay[] enemyWays = GameObject.FindObjectsOfType<AttackWay>();
        foreach (AttackWay enemyBorn in enemyWays)
        {
            if (enemyBorn.transform.position.y == transform.position.y)
            {
                attackway = enemyBorn;
                return;
            }
        }
    }
    bool AttackObjetIsWay()
    {
        if (attackway.transform.childCount <= 0)
        {
            return false;
        }

        foreach (Transform Child in attackway.transform)
        {
            if (Child.transform.position.x > transform.position.x)
            {
                return true;
            }
        }
        return false;
    }
    void FireAmmo()
    {
        weaponsParent = GameObject.Find("Weapons");
        GameObject ammo = Instantiate(weapons) as GameObject;
        ammo.transform.position = begin.transform.position;
        ammo.transform.parent = weaponsParent.transform;
    }
}
