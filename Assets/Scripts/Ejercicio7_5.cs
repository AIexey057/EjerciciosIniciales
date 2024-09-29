using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    int numero = 1;
    [SerializeField] int maximo;
    // Start is called before the first frame update
    void Start()
    {
        //He buscado el como hacer que el numero del inspector no pueda ser negativo
        if (maximo <= 0)
        {
            Debug.LogWarning("El numero introducido no puede ser menor o igual a 0");
            maximo = 1;
        }

        while(numero <= maximo)
        {
            Debug.Log(numero);
            numero++;
        }
        for (int numero1 = 1; numero1 <= maximo; numero1++)
        {
            Debug.Log(numero1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
