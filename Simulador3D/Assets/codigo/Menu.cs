using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public int graf = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cuadratica()
    {
        graf = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void lineal1()
    {
        graf = 2;
        SceneManager.LoadScene("SampleScene");
    }

    public void lineal2()
    {
        graf = 3;
        SceneManager.LoadScene("SampleScene");
    }

    public void seno()
    {
        graf = 4;
        SceneManager.LoadScene("SampleScene");
    }

    public void coseno()
    {
        graf = 5;
        SceneManager.LoadScene("SampleScene");
    }

    public void raiz()
    {
        graf = 6;
        SceneManager.LoadScene("SampleScene");
    }

    public void pol()
    {
        graf = 7;
        SceneManager.LoadScene("SampleScene");
    }
}
