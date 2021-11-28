using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Saludmega : MonoBehaviour
{
    [SerializeField] int salud;
    public GameObject Reinicio;
    public Image Over;
    public AudioSource megdead;

    void Start()
    {
        Over.enabled = false;
        Reinicio.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        
        
        if (col.collider.CompareTag("enemy"))
        {
            megdead.Play();
                Destroy(gameObject);
            Over.enabled = true;
           Reinicio.gameObject.SetActive(true);
        }
        if (col.collider.CompareTag("balasen"))
        {
            megdead.Play();
            Destroy(gameObject);
            Over.enabled = true;
           Reinicio.gameObject.SetActive(true);
        }
    }
}
