using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public string nombre = "Alex";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hellow World");
        Debug.Log("Este es el primer videojuego de "+  nombre);
        Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame loquete");// Esto aparece de forma tan repetida ya que se actualiza 1 vez por frame
    }
}
