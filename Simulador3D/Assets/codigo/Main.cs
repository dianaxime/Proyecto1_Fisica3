using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /************************************************* variables ***********************************************/

    //tabla
    public double y1, x1;
    public double y2, x2;
    public double y3, x3;
    public double y4, x4;
    public double y5, x5;

    //carga, masa y velocidad inicial
    public double masa;
    public double carga;
    public double veIn;

    //resultados
     double ve1;
     double ve2;
     double ve3;
     double ve4;
     double veFi;

    private Vector3 start;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        ve1 = Math.Sqrt((y1 * 2) / masa);
        ve2 = Math.Sqrt((y2 * 2) / masa);
        ve3 = Math.Sqrt((y3 * 2) / masa);
        ve4 = Math.Sqrt((y4 * 2) / masa);
        veFi = Math.Sqrt((y5 * 2) / masa);

    }

    // Update is called once per frame
    void Update()
    {
        int distancia = 0;
        float vel1 = (float)ve1;
        float vel2 = (float)ve2;
        float vel3 = (float)ve3;
        float vel4 = (float)ve4;
        float vel5 = (float)veFi;
        if (distancia <= x1)
        {
            transform.position = start + new Vector3(vel1, 0, 0);
            distancia = distancia + 1;
        }
        else if (distancia > x1 && distancia <= x2)
        {
            transform.position = start + new Vector3(vel2, 0, 0);
            distancia = distancia + 1;
        }
        else if (distancia > x2 && distancia <= x3)
        {
            transform.position = start + new Vector3(vel3 * Time.deltaTime, 0, 0);
            distancia = distancia + 1;
        }
        else if (distancia > x3 && distancia <= x4)
        {
            transform.position = start + new Vector3(vel4 * Time.deltaTime, 0, 0);
            distancia = distancia + 1;
        }
        else if (distancia > x4 && distancia <= x5)
        {
            transform.position = start + new Vector3(vel5 * Time.time, 0, 0);
            distancia = distancia + 1;
        }
       /* else if (distancia > x5)
        {
            //termina la simulacion

        }*/

    }
}
