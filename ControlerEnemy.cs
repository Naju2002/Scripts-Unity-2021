using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerEnemy : MonoBehaviour
{
    public int health;
    public int speed;
    public int attackDistance;

    protected bool isMoving = false;

    protected Rigidbody2D rd2d;
    protected Animator anin;
    public Transform player;
    protected SpriteRenderer sprite;


    void Awake()
    {
        rd2d = GetComponent<Rigidbody2D>();
        anin = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

   protected float PlayerDistance()
    {
        return Vector2.Distance(player.position, transform.position);
    }

    protected void Flip()
    {
        sprite.flipX = !sprite.flipX;
        speed *= -1;
    }

}
