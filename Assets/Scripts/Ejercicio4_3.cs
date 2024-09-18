using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] float cantidad;
    [SerializeField]string moneda;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Convertir(float cantidad, string moneda)
    {
        if (moneda == "euro")
        {
            cantidad /= 1.11f;
            moneda = "dolar";
        }
        else if (moneda == "dolar")
        {
            cantidad *= 1.11f;
        }
        resultado = cantidad;
        
    }
}
