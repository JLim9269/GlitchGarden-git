using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    // Configuration Parameters
    [SerializeField] float currentSpeed = 1f;
    [SerializeField] float damage = 100f;

	void Update ()
    {
        transform.Translate(Vector2.right * currentSpeed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        var attacker = other.GetComponent<Attacker>();
        if (health && attacker)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
