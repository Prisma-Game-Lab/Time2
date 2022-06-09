using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurtbox : MonoBehaviour
{
    public BoxCollider2D hurtbox;
    public PlayerStats stats;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("EnemyAttack"))
        {
            if (stats.invincible == false)
            {
                stats.health--;
                stats.invincible = true;
            }
        }
    }
}
