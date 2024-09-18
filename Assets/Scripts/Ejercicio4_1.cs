using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField]float base1;
    [SerializeField] float altura;
    [SerializeField] float radio;
    [SerializeField] float lado;
    
    // Start is called before the first frame update
    void Start()
    {
        float areaCuadradoResultado = Cuadrado(lado);
        float areaCirculoResultado = Circulo(radio);
        float areaTrianguloResultado = Triangulo(base1, altura);
        Debug.Log("El area del cuadrado es " + areaCuadradoResultado);
        Debug.Log("El area del circulo es " + areaCirculoResultado);
        Debug.Log("El area del triangulo es " + areaCirculoResultado);
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

    float Circulo( float radio)
    {
        areaCirculo = (radio * radio) * Mathf.PI ;
        return areaCirculo;
    }
    float Triangulo(float base1, float altura)
    {
        areaTriangulo = (base1 * altura) / 2;
        return areaTriangulo;
    }
}
