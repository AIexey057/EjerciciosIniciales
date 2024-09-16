using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadInicial;
    float velocidad;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log( velocidad = (velocidadInicial * 1000) / 3600);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
