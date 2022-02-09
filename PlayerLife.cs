using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    Animator anim;

    bool vivo = true;

    

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        GameManager.gm.AtualizaHud();
    }

    void Update()
    {
        
    }
     
    public void PerdeVida()
    {
        if (vivo)
        {
            vivo = false;
            anim.SetTrigger("dead");
            GameManager.gm.SetVidas(-1);
            gameObject.GetComponent<player>().enabled = false;
        
        }
       
    }

    public void Reset()
    {
        if(GameManager.gm.GetVidas() >= 0)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }
}
