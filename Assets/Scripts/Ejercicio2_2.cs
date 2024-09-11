using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Ejercicio2_2 : MonoBehaviour
{
    int vida = 10;
    float exp = 5;
    char carac = 'a';
    float resultadoSuma;
    float resultadoResta;
    
    // Start is called before the first frame update
    void Start()
    {
        resultadoSuma = vida + exp;
        resultadoResta = vida - exp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
