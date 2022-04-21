using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemyBigandSmall : MonoBehaviour
{
    public int health;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health -= 100;
            if (health <= 0)
            {
                Die();
            }
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
