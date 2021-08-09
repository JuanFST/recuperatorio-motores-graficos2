using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoree : MonoBehaviour
{
    public Text TextoDeScoree;
    public float CantidadDePuntos;
    public float PuntosPorSegundo;

    void Start()
    {
        CantidadDePuntos = 0f;
        PuntosPorSegundo = 5f;
    }
    void Update()
    {
        TextoDeScoree.text = "Score: "+(int)CantidadDePuntos;
        CantidadDePuntos += PuntosPorSegundo * Time.deltaTime;
    }
}
