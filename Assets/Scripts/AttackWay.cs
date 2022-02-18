using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackWay : MonoBehaviour
{
    [SerializeField] GameObject[] attackObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject enemy in attackObject)
        {
            if (isTimeAttack(enemy))
            {
                goAttack(enemy);
            }
        }
    }

    bool isTimeAttack(GameObject enemy)
    {
        Attacked attackedObject = enemy.GetComponent<Attacked>();
        float wait = attackedObject.second;
        float waitRate = 1 / wait;
        float finshRate = waitRate * Time.deltaTime;
        if (Random.value < finshRate)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void goAttack(GameObject enemy)
    {
        GameObject attacker = Instantiate(enemy, transform.position, Quaternion.identity) as GameObject;
        attacker.transform.parent = transform;
    }
}
