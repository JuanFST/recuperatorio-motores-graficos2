using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour
{
    public Transform puntoDeDisparo;
    public Transform puntoDeEfecto;
    public GameObject prefabBala;
    public GameObject efectoDeDisparo;
    public float fuerzaBala = 20f;
    public AudioSource SonidoBala;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
            SonidoBala.Play();
        }
    }

    void Disparar()
    {
        GameObject efctoTemporal = Instantiate(efectoDeDisparo, puntoDeEfecto.position, puntoDeEfecto.rotation);

        GameObject bala = Instantiate(prefabBala, puntoDeDisparo.position, puntoDeDisparo.rotation);

        Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();

        rb.AddForce(puntoDeDisparo.up * fuerzaBala, ForceMode2D.Impulse);


        Destroy(efctoTemporal, 2f);
        Destroy(bala, 3f);

    }
    private void OnCollisionEnter2D(Collision2D colisionBala)
    {
       


        if (colisionBala.gameObject.tag == "enemigo" || colisionBala.gameObject.tag == "obstaculo")
         {
            

            GameObject bala = Instantiate(prefabBala, puntoDeDisparo.position, puntoDeDisparo.rotation);

            Destroy(bala);


        }



    }
}
