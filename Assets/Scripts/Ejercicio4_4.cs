using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float velocidadKmh;
    float velocidadMs;
    // Start is called before the first frame update
    void Start()
    {
        Velocidad(velocidadKmh);
        Debug.Log("Vas a " + velocidadMs + " metros por segundo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Velocidad(float velocidadKmh)
    {
        velocidadMs = (velocidadKmh * 1000) / 3600;
        return velocidadMs;
    }
}
