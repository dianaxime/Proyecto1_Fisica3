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
    public double x1;
    public double x2;
    public double x3;
    public double x4;
    public double x5;

    //carga, masa y velocidad inicial
    public double masa;
    public double carga;
    public double veIn;
    public int grafica;
    private Vector3 start;
    private Vector3 posis1;
    private Vector3 posis2;


    //resultados
    public double ve1;
    public double ve2;
    public double ve3;
    public double ve4;
    public double veFi;
    public float po1;
    public float po2;
    public float po3;
    public float po4;
    public float po5;

   public float vel1;
   public float vel2 ;
   public float vel3 ;
   public float vel4 ;
   public float vel5 ;
   public float xx1 ;
   public float xx2;
   public float xx3;
   public float xx4;
   public float xx5;



    // Start is called before the first frame update
    void Start()
    {
        // Posicion inicial de la particula
        start = transform.position;
        posis1 = new Vector3(xx1, 0, 0);
        // Velociades 
        ve1 = Math.Sqrt(((2 * carga * Math.Abs(y1 - y2))/ masa) + (veIn * veIn));
        ve2 = Math.Sqrt(((2 * carga * Math.Abs(y2 - y3)) / masa) + (ve1 * ve1));
        ve3 = Math.Sqrt(((2 * carga * Math.Abs(y3 - y4)) / masa) + (ve2 * ve2));
        ve4 = Math.Sqrt(((2 * carga * Math.Abs(y4 - y5)) / masa) + (ve3 * ve3));
        veFi = Math.Sqrt(((2 * carga * y5) / masa) + (ve4 * ve4));

        //posiciones
        

        
        // posiciones
        /*tiempo = 1;
        po1 = (float)ve1 * tiempo;
        tiempo = 2;
        po2 = (float)ve2 * tiempo;
        tiempo = 3;
        po3 = (float)ve3 * tiempo;
        tiempo = 4;
        po4 = (float)ve4 * tiempo;
        tiempo = 5;
        po5 = (float)veFi * tiempo;*/

        

    }

    // Update is called once per frame
    void Update()
    {
         vel1 = (float)ve1;
         vel2 = (float)ve2;
         vel3 = (float)ve3;
         vel4 = (float)ve4;
         vel5 = (float)veFi;
         xx1 = (float)x1;
         xx2 = (float)x2;
         xx3 = (float)x3;
         xx4 = (float)x4;
         xx5 = (float)x5;
        transform.position = start + new Vector3(xx1 , 0, 0).normalized * vel1 * Time.time;

        /*transform.position = start + new Vector3(po1/100, 0, 0);
        transform.position = new Vector3(po1/100, 0, 0) + new Vector3(po2, 0, 0);
        transform.position = new Vector3(po2/100, 0, 0) + new Vector3(po3, 0, 0);
        transform.position = new Vector3(po3/100, 0, 0) + new Vector3(po4, 0, 0);
        transform.position = new Vector3(po4, 0, 0) + new Vector3(po5, 0, 0);*/
        /* if (distancia <= x1)
         {
             transform.position = start + new Vector3(vel1 * Time.time, 0, 0);
             distancia = distancia + 0.05;
             holi = this.transform.position;
         }
         else if (distancia > x1 && distancia <= x2)
         {
             transform.position = new Vector3(vel2 * Time.time, 0, 0);
             distancia = distancia + 0.05;
             holi1 = this.transform.position;
         }
         else if (distancia > x2 && distancia <= x3)
         {
             transform.position =  new Vector3(vel3 * Time.time, 0, 0);
             distancia = distancia + 0.05;
             holi2 = this.transform.position;
         }
         else if (distancia > x3 && distancia <= x4)
         {
             transform.position =  new Vector3(vel4 * Time.time, 0, 0);
             distancia = distancia + 0.05;
             holi3 = transform.position;
         }
         else if (distancia > x4 && distancia <= x5)
         {
             transform.position = new Vector3(vel5 * Time.time, 0, 0);
             distancia = distancia + 0.05;
         }*/
    }
}
