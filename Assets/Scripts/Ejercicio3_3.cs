using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int monedas = 10;
    int monedas2;
    int monedas3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(monedas2 = monedas * 2);
        Debug.Log(monedas3 = monedas * 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
