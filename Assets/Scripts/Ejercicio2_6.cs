using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 4;
    int puntuacion2 = 8;
    int puntuacion3 = 6;
    int puntuacionTotal;
    int puntuacionSuma;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(puntuacionSuma = puntuacion1 + puntuacion2 + puntuacion3);
       Debug.Log(puntuacionTotal = puntuacionSuma / 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
