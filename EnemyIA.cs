using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyIA : ControlerEnemy
{
    public bool seguir = true;

    void Start()
    {
        health = 2;
    }
    void Update()
    {
        float distance = PlayerDistance();
        isMoving =  (distance <= attackDistance);
        
        
        if (isMoving)
        {
            seguir = true;
            anim.SetBool("seguir",seguir);
        }
        else
        {
            seguir = false;
            anim.SetBool("seguir",seguir);
        }

        if (isMoving)
        {

            if ((player.position.x > transform.position.x && sprite.flipX) ||
               (player.position.x < transform.position.x && !sprite.flipX))
            {
                Flip();
            }

        }
    }

   void FixedUpdate()
    {
        if (isMoving)
        {
            rd2d.velocity = new Vector2(speed, rd2d.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerLife>().PerdeVida();
        }
    }

}



