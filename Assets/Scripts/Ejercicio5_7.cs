using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocidad1;
    [SerializeField] int velocidad2;
    [SerializeField] int velocidad3;
    // Start is called before the first frame update
    void Start()
    {
        CalcularVelocidad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CalcularVelocidad()
    {
        if(velocidad1 >= velocidad2 && velocidad1 >= velocidad3)
        {
            Debug.Log("El jugador 1 empieza primero");
        }
        else if (velocidad2 >= velocidad1 && velocidad2 >= velocidad3)
        {
            Debug.Log("El jugador 2 empieza primero");
        }
        else if(velocidad3 >= velocidad1 && velocidad3 >= velocidad2)
        {
            Debug.Log("El jugador 3 empieza primero");
        }
    }
}
