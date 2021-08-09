using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollerFondo : MonoBehaviour
{
    public BoxCollider2D collider2d;
    public Rigidbody2D rb;
    private float ancho;
    private float velocidadScroll = -2f;
    // Start is called before the first frame update
    void Start()
    {
        collider2d = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        ancho = collider2d.size.x;
        collider2d.enabled = false;
        rb.velocity = new Vector2(velocidadScroll, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.position.x < -ancho)
        {
            Vector2 reiniciarPos = new Vector2(ancho * 2f -1, 0);
            transform.position = (Vector2)transform.position + reiniciarPos;
        }
    }
}
