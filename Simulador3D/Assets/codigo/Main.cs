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
    public double veIn = 10.15;

    //resultados
    public double ve1;
    public double ve2;
    public double ve3;
    public double ve4;
    public double veFi;

    private Vector3 start;
    private float Velocity;
    private float HorizontalDirection = -1;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;

        // de variables
        y1 = 2.2;
        x1 = 0.04;
        //***
        y2 = 1.5;
        x2 = 0.08;
        //***
        y3 = 1.05;
        x3 = 0.12;
        //***
        y4 = 0.6;
        x4 = 0.16;
        //***
        y5 = 0.2;
        x5 = 0.20;
        //***
        masa = 0.00005;
        carga = 3;

    }

    // Update is called once per frame
    void Update()
    {
        float veloci = (float)veIn;
        transform.position = start + new Vector3(veloci * Time.time, 0, 0);
    }

    // metodo para calcular la velocidad
    void velocidad()
    {

    }
}
