using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private Animator foxAnimator;
    private Attacked atack;
    // Start is called before the first frame update
    void Start()
    {
        foxAnimator = gameObject.GetComponent<Animator>();
        atack = gameObject.GetComponent<Attacked>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject triggerFox = collision.gameObject;
        if (!triggerFox.GetComponent<Defenders>())
        {
            return;
        }
        else if (triggerFox.GetComponent<Stone>())
        {
            foxAnimator.SetTrigger("isJump");
        }
        else
        {
            foxAnimator.SetBool("isAttack",true);
            atack.Target(triggerFox);
        }
    }
}
