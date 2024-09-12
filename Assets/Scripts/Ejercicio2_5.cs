using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 10;//40
    int vidasPlayer2 = 20;//30
    int vidasPlayer3 = 30;//10
    int vidasPlayer4 = 40;//
    int intercambioDeVidas;
    // Start is called before the first frame update
    void Start()
    {
        intercambioDeVidas = vidasPlayer2;
        Debug.Log(vidasPlayer2 = vidasPlayer3);
        Debug.Log(vidasPlayer3 = vidasPlayer1);
        Debug.Log(vidasPlayer1 = vidasPlayer4);
        Debug.Log(vidasPlayer4 = intercambioDeVidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
