using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6_2 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero <= 0)
        {
            Debug.LogWarning("El numero introducido no puede ser menor o igual a 0");
            numero = 1;
        }
    }
    //No entiendo el ejercicio

    // Update is called once per frame
    void Update()
    {
        
    }
}
