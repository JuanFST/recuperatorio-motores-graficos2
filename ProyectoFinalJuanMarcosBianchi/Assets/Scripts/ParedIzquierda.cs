using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedIzquierda : MonoBehaviour
{
    public GameObject asteroide;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstaculo")
        {
            Destroy(gameObject);
        }
    }
}
