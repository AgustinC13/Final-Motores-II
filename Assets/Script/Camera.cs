using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camera : MonoBehaviour
{
    // Declaracion de Variables
    public GameObject[] listaCamaras;
    int ncamaras = 4;

    // Start is called before the first frame update
    void Start()
    {

        // Desactivamos todas nuestras cámaras, en bucle de forma eficiente
        for (int i=0; i<ncamaras; i++)
        {
            listaCamaras[i].gameObject.SetActive(false);
        }
        
        //Activamos nuestra primera camara
        listaCamaras[0].gameObject.SetActive(true);

    }

    // Desactivamos todas nuestras cámaras, en bucle de forma eficiente
    void ApagarCamaras()
    {
        for (int i = 0; i < ncamaras; i++)
        {
            listaCamaras[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Debug.Log("Tecla 1 pulsada");
            ApagarCamaras();
            //Activamos nuestra primera camara
            listaCamaras[0].gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Debug.Log("Tecla 2 pulsada");
            ApagarCamaras();
            //Activamos nuestra primera camara
            listaCamaras[1].gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Debug.Log("Tecla 3 pulsada");
            ApagarCamaras();
            //Activamos nuestra primera camara
            listaCamaras[2].gameObject.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            Debug.Log("Tecla 4 pulsada");
            ApagarCamaras();
            //Activamos nuestra primera camara
            listaCamaras[3].gameObject.SetActive(true);
        }
    }
}
