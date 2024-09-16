using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int exp;
    float nivel;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(nivel = 32 + (9 * exp/5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
