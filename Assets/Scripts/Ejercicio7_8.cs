using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numeroInicial;
    [SerializeField] int numeroFinal;
    // Start is called before the first frame update
    void Start()
    {
        if (numeroInicial <= 0 || numeroInicial > numeroFinal)
        {
            Debug.LogWarning("Los numeros no estan bien puestos");

        }
        while (numeroInicial < numeroFinal)
        {
              numeroInicial++;
            if (numeroInicial % 2 == 0)
            {
                Debug.Log(numeroInicial);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
