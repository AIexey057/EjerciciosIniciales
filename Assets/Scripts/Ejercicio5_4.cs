using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float divisor;
    [SerializeField] float dividendo;
     float cociente;
    // Start is called before the first frame update
    void Start()
    {
        if (divisor != 0)
        {
            Debug.Log(cociente = divisor / dividendo);
        }
        else if (divisor == 0)
        {
            Debug.Log("El divisor no puede ser 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
