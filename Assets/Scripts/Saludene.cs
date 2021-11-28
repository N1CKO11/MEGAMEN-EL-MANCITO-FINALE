using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Saludene : MonoBehaviour
{
    [SerializeField] int numDisparos;
    [SerializeField] GameObject destrucioon;
    Animator anim;
    public GameObject rangou;
    [SerializeField] Gamemanager gm;
    public AudioSource muerteE;

    void Start()
    {
     
        anim = GetComponent<Animator>();
        anim.SetBool("destruc", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
  
    public void OnCollisionEnter2D(Collision2D col)
    {
      ReducirVida();
      if(numDisparos <1)
        {
            if (col.collider.CompareTag("bala"))
            {
               
                anim.SetBool("destruc", true);
                //Destroy(gameObject);
                Debug.Log("cuch�plan");
                gm.ReducirNumEnemigos();
                GetComponent<BoxCollider2D>().enabled = false;
                GetComponent<Enemy>().enabled = false;
                rangou.SetActive(false);
                Instantiate(destrucioon, transform.position, Quaternion.identity);
                muerteE.Play();
            }
        }
        
       
        
        
    }
    void ReducirVida()
    {

        numDisparos = numDisparos - 1;
    }

}

