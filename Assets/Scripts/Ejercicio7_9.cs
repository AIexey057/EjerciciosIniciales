using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    int numeroInicial = 1;
    [SerializeField] int numeroFinal;
    // Start is called before the first frame update
    void Start()
    {
        if (numeroFinal < 3)
        {
            Debug.LogWarning("El numero introducido no puede ser menor 3");
            
        }
        while(numeroInicial < numeroFinal)
        {
            numeroInicial++;
            if(numeroInicial % 3 == 0)
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
