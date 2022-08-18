using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUNTAJES : MonoBehaviour
{
    [SerializeField] int[] array_puntajes = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ObtenerMayorPuntaje());
        Debug.Log(ObtenerNivelDeMenorPuntaje());
        Debug.Log(ObtenerPuntajePromedio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    int ObtenerMayorPuntaje()
    {
        int mayor = 0;
        foreach(int num in array_puntajes)
        {
            if(num > mayor)
            {
                mayor = num;
            }
        }
        return mayor;
    }

    int ObtenerNivelDeMenorPuntaje()
    {
        int menor = 0;
        for (int i = 0; i < array_puntajes.Length; i++)
        {
            if (array_puntajes[i] < array_puntajes[menor])
            {
                menor = i;
            }
        }
        return menor;
    }

    float ObtenerPuntajePromedio()
    {
        float promedio = 0;
        foreach(int num in array_puntajes)
        {
            promedio += num;
        }
        promedio /= array_puntajes.Length;
        return promedio;
    }
}
