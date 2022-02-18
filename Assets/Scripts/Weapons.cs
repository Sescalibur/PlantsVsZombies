using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attacked attacker = collision.gameObject.GetComponent<Attacked>();
        Health health = collision.gameObject.GetComponent<Health>();
        if (health && attacker)
        {
            health.Damage(damage);
            Destroy(gameObject);
        }
    }
}
