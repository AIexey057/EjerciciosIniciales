using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] float temperatura;
    // Start is called before the first frame update
    void Start()
    {
        if (temperatura <= 10)
        {
            Debug.Log("Tienes frio");
        }
        else if (temperatura > 10 && temperatura <= 20)
        {
            Debug.Log("Tienes algo de frio");
        }
        else if (temperatura > 20 && temperatura <= 30)
        {
            Debug.Log("Tienes algo de calor");
        }
        else if (temperatura > 30)
        {
            Debug.Log("Tienes calor");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
