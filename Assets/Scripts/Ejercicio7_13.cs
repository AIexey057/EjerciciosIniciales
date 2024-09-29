using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int numero;
    bool EsNumeroPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Mathf.Sqrt(numero); i++)//Esto lo tuve que buscar
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        
        return true;
    }

    
    void Start()
    { 
        if (EsNumeroPrimo(numero))
        {
            Debug.Log(numero + " es un número primo.");
        }
        else
        {
            Debug.Log(numero + " no es un número primo.");
        }
    }
}
