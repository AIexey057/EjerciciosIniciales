using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombre = "Alex";
    string apellido1 = "González";
    string apellido2 = "García";
    string edad = "19";
    // Start is called before the first frame update
    void Start()
    {
        string infoRecogido = ConstruirNombre(nombre,apellido1,apellido2,edad);
        Debug.Log(infoRecogido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string ConstruirNombre(string nombre, string apellido1, string apellido2, string edad)
    {
        string info = ("La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad + " años."); 
        return info;
    }
}
