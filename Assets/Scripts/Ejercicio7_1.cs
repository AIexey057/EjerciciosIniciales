using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6_2 : MonoBehaviour
{
    int numero = 1;
    // Start is called before the first frame update
    void Start()
    {
        while(numero <= 100)
        {
            Debug.Log(numero);
            numero++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
