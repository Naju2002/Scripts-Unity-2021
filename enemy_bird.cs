using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bird : ControlerEnemy
{
    public float velocidadeDoInimigo;


    private Transform posicaoDoJogador;


    void Start()
    {
        health = 1;
        posicaoDoJogador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (posicaoDoJogador.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posicaoDoJogador.position, velocidadeDoInimigo * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerLife>().PerdeVida();
        }
    }
}
