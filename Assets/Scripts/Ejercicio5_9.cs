using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int enemigo;
    int vida;
    int damage;
    // Start is called before the first frame update
    void Start()
    {
        if (enemigo == 1)
        {
            damage = 350; vida = 650;
            Debug.Log("Este enemigo tiene " + damage + " de daño y " + vida + " de vida");
        }
        else if (enemigo == 2)
        {
            damage = 300; vida = 550;
            Debug.Log("Este enemigo tiene " + damage + " de daño y " + vida + " de vida");
        }
        else if (enemigo == 3)
        {
            damage = 300; vida = 500;
            Debug.Log("Este enemigo tiene " + damage + " de daño y " + vida + " de vida");
        }
        else if (enemigo == 4)
        {
            damage = 310; vida = 460;
            Debug.Log("Este enemigo tiene " + damage + " de daño y " + vida + " de vida");
        }
        else if (enemigo == 5)
        {
            damage = 280; vida = 490;
            Debug.Log("Este enemigo tiene " + damage + " de daño y " + vida + " de vida");
        }
        else if (enemigo == 6)
        {
            damage = 360; vida = 520;
            Debug.Log("Este enemigo tiene " + damage + " de daño y " + vida + " de vida");
        }
        else
        {
            Debug.Log("Ese enemigo no existe");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
