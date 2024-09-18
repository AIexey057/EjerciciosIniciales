using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float base1;
    [SerializeField] float altura;
    float area;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( area = (base1 * altura)/2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
