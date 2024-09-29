using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField]float numeroInicial;
    [SerializeField] float numeroFinal;
    // Start is called before the first frame update
    void Start()
    {
        if (numeroInicial > numeroFinal)
        {
            Debug.LogWarning("El numero inicial debe de ser menor");

        }
        while(numeroInicial < numeroFinal)
        {
            numeroInicial++;
            if (numeroInicial % 2 == 0 && numeroInicial >= 0)
            {
                Debug.Log(numeroInicial + " Este número es par y positivo");
            }
            else if (numeroInicial < 0 && numeroInicial % 2 != 0)
            {
                Debug.Log(numeroInicial + " Este numero es negativo e impar");
            }
            else if (numeroInicial % 2 == 0 && numeroInicial < 0)
            {
                Debug.Log(numeroInicial + " Este número es par y negativo");
            }
            else if (numeroInicial % 2 != 0 && numeroInicial >= 0)
            {
                Debug.Log(numeroInicial + " Este número es impar y positivo");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
