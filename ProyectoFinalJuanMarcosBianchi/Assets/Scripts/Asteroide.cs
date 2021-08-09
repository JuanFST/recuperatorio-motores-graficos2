using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public float velocidadAsteroide = -4f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = new Vector2(velocidadAsteroide, 0);

    }

     void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "bala")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "jugador")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "limite")
        {
            Destroy(gameObject);
        }
    }
}
