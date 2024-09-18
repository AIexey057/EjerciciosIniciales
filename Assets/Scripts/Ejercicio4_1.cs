using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField]float base1;
    [SerializeField] float altura;
    [SerializeField] float radio;
    [SerializeField] float lado;
    float areaCuadrado;
    float areaCirculo;
    float areaTriangulo;
    // Start is called before the first frame update
    void Start()
    {
        Cuadrado(lado);
        circulo(radio);
        triangulo(base1, altura);
        Debug.Log("El area del cuadrado es " + areaCuadrado);
        Debug.Log("El area del circulo es " + areaCirculo);
        Debug.Log("El area del triangulo es " + areaTriangulo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    float Cuadrado(float lado)
    {
        areaCuadrado = lado * 2;
        return areaCuadrado;
    }

    float circulo( float radio)
    {
        areaCirculo = (radio * radio) * Mathf.PI ;
        return areaCirculo;
    }
    float triangulo(float base1, float altura)
    {
        areaTriangulo = (base1 * altura) / 2;
        return areaTriangulo;
    }
}
