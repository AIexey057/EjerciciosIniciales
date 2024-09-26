using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero >= 0 && numero <= 9)
        {
            Debug.Log("Si esto sale es que lo he hecho bien");
        }
        else
        {
            Debug.Log("Si sale esto es que lo he cho bien si no es lo que pide");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
