using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel;
    // Start is called before the first frame update
    void Start()
    {
        NivelPokemon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void NivelPokemon()
    {
        if(nivel % 10 == 0)
        {
            Debug.Log("Tu pokemon aprendio un nuevo ataque");
        }
        else
        {
            Debug.Log("");
        }
    }
}
