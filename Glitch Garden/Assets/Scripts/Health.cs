using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    // Configuration Parameters
    [SerializeField] float health = 100;

    [SerializeField] GameObject deathVFX;
    [SerializeField] float durationOfVFX = 1f;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        if (!deathVFX)
        {
            return;
        }
        GameObject death = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(death, durationOfVFX);
    }
}
