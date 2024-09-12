using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vida = 10;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log( vida += 77);
       Debug.Log( vida -= 3);
       Debug.Log( vida *= 4);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
