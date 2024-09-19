using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField] string moneda;
    [SerializeField] float cantidad;
    string info;
    
    
    // Start is called before the first frame update
    void Start()
    {
       string infoCompleta = Convertir(cantidad, moneda);
       Debug.Log("Primero ingrese la cantidad que desee, despues si quiere cambiar de euro a dolar esciba euro, sino escriba dolar");
       Debug.Log(infoCompleta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string Convertir(float cantidad, string moneda)
    {
        if (moneda == "euro")
        {
            cantidad /= 1.11f;
            moneda = "dolares";
        }
        else if (moneda == "dolares")
        {
            cantidad = cantidad * 1.11f;
            moneda = "euros";
        }
        info = ("Tienes " + cantidad + " " +  moneda);
        return info;
    }
}
