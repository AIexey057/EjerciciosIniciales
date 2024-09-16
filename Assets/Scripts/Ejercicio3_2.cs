using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_2 : MonoBehaviour
{
    string nombre = "Alex";
    [SerializeField] string frase = "Bienvenido de nuevo, Alex";
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Bienvenido de nuevo, " +  nombre); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
