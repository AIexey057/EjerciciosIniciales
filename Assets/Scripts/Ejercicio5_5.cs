using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivel;
    // Start is called before the first frame update
    void Start()
    {
        NivelPersonaje();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void NivelPersonaje()
    {
        if(nivel % 2 == 0)
        {
            Debug.Log("Este número es par");
        }
        else
        {
            Debug.Log("Este número es impar");
        }
    }
}
