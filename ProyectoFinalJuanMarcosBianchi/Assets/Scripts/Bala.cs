using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public GameObject efectoDeImpacto;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       GameObject efecto = Instantiate(efectoDeImpacto, transform.position, Quaternion.identity);
        if (collision.gameObject.tag == "obstaculo")
        {
            Destroy(gameObject);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "enemigo")
        {
            Destroy(gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 1f);
            Destroy(gameObject);
        }
    }
}