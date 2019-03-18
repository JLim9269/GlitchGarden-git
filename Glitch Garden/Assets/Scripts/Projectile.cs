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
        if (other.gameObject.tag == "Attacker")
        {
            Destroy(gameObject);
            var health = other.GetComponent<Health>();
            health.DealDamage(damage);
        }
    }
}
