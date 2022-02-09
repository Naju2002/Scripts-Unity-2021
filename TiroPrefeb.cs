using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TiroPrefeb : MonoBehaviour
{
    [SerializeField]
  private float _velocidade;

    [SerializeField]
  private int _dano = 1;

   

    void Start()
    {
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * _velocidade;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            return;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var inimigoObj = collision.GetComponent<CompEnemy>();
            inimigoObj.TomaDano(_dano);
        }
        Destroy(gameObject);

    }

}
