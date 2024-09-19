using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField] float lado;
    [SerializeField] string moneda;
    string info;
    float areaCuadrado;
    // Start is called before the first frame update
    void Start()
    {
        Cuadrado(lado);
       string total = Convertir( areaCuadrado, moneda);
        Debug.Log(total);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Cuadrado(float lado)
    {
        float areaCuadrado = lado * 2;
        return areaCuadrado;
    }
    string Convertir(float areaCuadrado, string moneda)
    {
        if (moneda == "euro")
        {
            areaCuadrado /= 1.11f;
            moneda = "dolares";
        }
        else if (moneda == "dolares")
        {
            areaCuadrado = areaCuadrado * 1.11f;
            moneda = "euros";
        }
        info = ("Tienes " + areaCuadrado + " " + moneda);
        return info;
    }
}
