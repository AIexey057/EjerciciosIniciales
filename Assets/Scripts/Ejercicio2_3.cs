using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3ç : MonoBehaviour
{
    int vidas = 5;
    float exp = 4;
    float producto;
    float cociente;
    float resto;
    int dobleVidas;
    float tripleExp;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(producto = vidas * exp);
       Debug.Log(cociente = vidas / exp);
       Debug.Log(resto = cociente % exp);
       Debug.Log(tripleExp = exp * 3);
       Debug.Log(dobleVidas = vidas * 2);
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
