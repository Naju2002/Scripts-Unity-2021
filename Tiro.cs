using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    [SerializeField]
    private Transform _posicaoDeTiro;
    [SerializeField]
    private GameObject _tiroPrefab;
    
    void Update()
    {
        // dectetar que jogador apertou o botão de tiro 
        if(Input.GetButtonDown("Fire1"))
        {
            Atira();
        }
    }

    private void Atira()
    {
        // codigo pro tiro 
        Instantiate(_tiroPrefab, _posicaoDeTiro.position, _posicaoDeTiro.rotation);
    }
}
