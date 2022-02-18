using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timsah : MonoBehaviour
{
    private Animator timsahAnimator;
    private Attacked atack;
    // Start is called before the first frame update
    void Start()
    {
        timsahAnimator = gameObject.GetComponent<Animator>();
        atack = gameObject.GetComponent<Attacked>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject triggerTimsah = collision.gameObject;
        if (!triggerTimsah.GetComponent<Defenders>())
        {
            return;
        }
        else
        {
            timsahAnimator.SetBool("isAttack", true);
            atack.Target(triggerTimsah);
        }
    }
}