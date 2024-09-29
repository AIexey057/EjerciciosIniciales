using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int horas;
    [SerializeField] int minutos;
    [SerializeField] int segundos;
    // Start is called before the first frame update
    void Start()
    {
        if(horas <= 24 && horas >= 0 && minutos <= 60 && minutos >= 0 && segundos <= 60 && segundos >= 0)
        {
            Debug.Log("Son las " + horas + ":" + minutos + ":" + segundos);
        }
        else
        {
            Debug.Log("Error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
