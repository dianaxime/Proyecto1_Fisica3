using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /************************************************* variables ***********************************************/

    public double distancia = 0;

    //tabla
    public double y1;
    public double y2;
    public double y3;
    public double y4;
    public double y5;
    public int x1;
    public int x2;
    public int x3;
    public int x4;
    public int x5;

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
    private Vector3 holi;
    private Vector3 holi1;
    private Vector3 holi2;
    private Vector3 holi3;

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
        float vel1 = (float)ve1;
        float vel2 = (float)ve2;
        float vel3 = (float)ve3;
        float vel4 = (float)ve4;
        float vel5 = (float)veFi;
        if (distancia <= x1)
        {
            transform.position = start + new Vector3(vel1 * Time.time, 0, 0);
            distancia = distancia + 0.05;
            holi = transform.position;
        }
        else if (distancia > x1 && distancia <= x2)
        {
            transform.position = holi + new Vector3(vel2 * Time.time, 0, 0);
            distancia = distancia + 0.05;
            holi1 = transform.position;
        }
        else if (distancia > x2 && distancia <= x3)
        {
            transform.position = holi1 + new Vector3(vel3 * Time.time, 0, 0);
            distancia = distancia + 0.05;
            holi2 = transform.position;
        }
        else if (distancia > x3 && distancia <= x4)
        {
            transform.position = holi2 + new Vector3(vel4 * Time.time, 0, 0);
            distancia = distancia + 0.05;
            holi3 = transform.position;
        }
        else if (distancia > x4 && distancia <= x5)
        {
            transform.position = holi3 + new Vector3(vel5 * Time.time, 0, 0);
            distancia = distancia + 0.05;
        }
       /* else if (distancia > x5)
        {
            //termina la simulacion

        }*/

    }
}
