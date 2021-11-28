using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Saludenetre : MonoBehaviour
{
    [SerializeField] int numDisparos;
    [SerializeField] GameObject destrucioon;
    [SerializeField] private float tiempodes;
    Animator anim;
    public GameObject rangou;
    [SerializeField] Gamemanager gm;
    public AudioSource muertepi;

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
        if (numDisparos < 1)
        {
            if (col.collider.CompareTag("bala"))
            {
             
                anim.SetBool("destruc", true);
                Debug.Log("cuch�plan");
                GetComponent<BoxCollider2D>().enabled = false;
                GetComponent<Enemigo3>().enabled = false;
                rangou.SetActive(false);
                gm.ReducirNumEnemigos();
                Instantiate(destrucioon, transform.position, Quaternion.identity);
                Destroy(gameObject, tiempodes);
                muertepi.Play();
            }
        }

        


    }
    void ReducirVida()
    {

        numDisparos = numDisparos - 1;
    }
}
