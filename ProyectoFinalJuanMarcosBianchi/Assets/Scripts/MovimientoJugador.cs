using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    public Rigidbody2D rb;
    Vector2 movimiento;
    Vector2 posicionMouse;
    public GameObject GameOverObject;
    public AudioSource Cancion;
    public Camera cam;

    private void Start()
    {
        Cancion.Play();
    }

    private void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");

        posicionMouse = cam.ScreenToWorldPoint(Input.mousePosition);

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadMovimiento, this.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void FixedUpdate()
    {
        if (rb.position.x > -8.8)
            rb.MovePosition(rb.position + movimiento * velocidadMovimiento * Time.fixedDeltaTime);

        Vector2 posicionAVer = posicionMouse - rb.position;
        float angulo = Mathf.Atan2(posicionAVer.y, posicionAVer.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angulo;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstaculo")
        {
            Destroy(gameObject);
            GameOver();
        }
    }
    public void GameOver()
    {
        GameOverObject.SetActive(true);
        Cancion.Stop();
    }

}
