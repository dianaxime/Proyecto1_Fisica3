using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /************************************************* variables ***********************************************/

 
    public double energiaI;

    //carga, masa y velocidad inicial
    public double masa;
    public double carga;
    public double veIn;

    //resultados
    public double veFi;
    public float po1x;
  
    
    public float time = 0.0f;
    float x = 0.0f;
    int sentido = 1;

    float funcion(float x)
    {
        return 0.01f *x*x;
        //return 10f * x;
        //return 0.01f * (float)Math.Sinh(x);
        //return 100f * (float)Math.Sqrt(Math.Abs(x));
        //return 0.01f * (float)Math.Cosh(x);
        //return -10f * x;
        //return 0.001f * x * x * x;
        //return 10f*(float)Math.Abs(x);
        //return 0.0001f*((float)Math.Pow(x, 6) * 0.5f)+(float)Math.Pow(x, 3) + (float)Math.Pow(x, 2) * 0.5f + (2*x) + 5f;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Posicion inicial de la particula
        energiaI = (0.5 * masa * veIn * veIn) + (carga *funcion(x));
    }

    // Update is called once per frame
    void Update()
    {
        if (energiaI - (carga *  (funcion(x) )) < 0)
        {
            x = x - po1x;
            sentido = sentido * -1;
            po1x = (float) Math.Sqrt((2 / masa) * (energiaI - (carga *  ( funcion(x))))) * 0.16f * sentido;
            Debug.Log(Time.deltaTime);
            time = time + Time.deltaTime;
            //x = x + po1x;
        }else
        {
            po1x = (float)Math.Sqrt((2 / masa) * (energiaI - (carga *  ( funcion(x))))) * 0.16f * sentido;
            Debug.Log(Time.deltaTime);
            time = time + Time.deltaTime;
            x = x + po1x;
        }
        transform.position = new Vector3(po1x, 0, 0);
    }
}
