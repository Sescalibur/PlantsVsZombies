using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour
{
    private Money cash;
    public int cost;
    private Animator _animator;
    private void Start()
    {
        cash = GameObject.FindObjectOfType<Money>();
        _animator = GetComponent<Animator>();
    }
    public void money(int coin)
    {
        cash.cashsUp(coin);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Fox"&& collision.gameObject.tag != "Ammo")
        {
            _animator.SetBool("isAttack", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _animator.SetBool("isAttack", false);
    }
}
