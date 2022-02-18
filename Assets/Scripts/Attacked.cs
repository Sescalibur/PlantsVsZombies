using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacked : MonoBehaviour
{
    [Range(0,2)] [SerializeField] float walkSpeed;
    private Animator _animator;
    private GameObject activeTarget;
    [Tooltip("Kaç saniyede bir düþman görülsün ? ")] public float second;
    // Start is called before the first frame update
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
        if (!activeTarget)
        {
            _animator.SetBool("isAttack",false);
        }
    }
    public void speed(float speed)
    {
        walkSpeed = speed;

    }

    public void Damaged(int damage)
    {
        if (activeTarget)
        {
            Health health = activeTarget.GetComponent<Health>();
            if (health)
            {
                health.Damage(damage);
            }
        }
    }

    public void Target(GameObject target)
    {
        activeTarget = target;
    }
}
