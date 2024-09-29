using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
   [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero <= 0 || numero > 100)
        {
            Debug.LogWarning("Por favor, introduce un número positivo entre 1 y 100.");
            return; // Salimos de la función si el número no es válido
        }
        Multiplicar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   void Multiplicar()
    {
        for (int numeroTabla = 1; numeroTabla <= 10; numero++)
        {
            int total = numero * numeroTabla;
            Debug.Log(numero + " x " + numeroTabla + " = " + total);
        }
    }
}
