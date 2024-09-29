using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numeroInicial;
    [SerializeField] int numeroFinal;
    // Start is called before the first frame update
    void Start()
    {
        
        if (numeroInicial <= 0 || numeroInicial > numeroFinal)//este se me ocurrio a mi pensando en que el numero final no puede ser menor al inicial
        {
            Debug.LogWarning("Los numeros no estan bien puestos");
            
        }
        while(numeroInicial < numeroFinal)
        {
            Debug.Log(numeroInicial);
            numeroInicial++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
