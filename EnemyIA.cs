using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : ControlerEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        health = 2;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = PlayerDistance();
        isMoving =  (distance <= attackDistance);

        if (isMoving)
        {
            if ((player.position.x > transform.position.x && sprite.flipX) ||
               (player.position.x < transform.position.x && !sprite.flipX))
            {
                Flip();
            }
        }
        Debug.Log(distance);

    }

   void FixedUpdate()
    {
        if (isMoving)
        {
            rd2d.velocity = new Vector2(speed, rd2d.velocity.y);
        }
    }


}



