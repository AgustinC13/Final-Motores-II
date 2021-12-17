using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    
    public InputField InputRadio;
    public InputField InputPoder;
    public Bum bum;
    public Camera camara;

    // Start is called before the first frame update
    void Start()
    {
        InputRadio.text = bum.radius.ToString();
        InputPoder.text = bum.power.ToString();

        InputRadio.onValueChanged.AddListener(delegate { Cambiar(); });
        InputRadio.onEndEdit.AddListener(delegate { Habilitar(); });

        InputPoder.onValueChanged.AddListener(delegate { Cambiar(); });
        InputPoder.onEndEdit.AddListener(delegate { Habilitar(); });
    }

    // Update is called once per frame
    void Update()
    {

        bum.radius = float.Parse(InputRadio.text);
        bum.power = float.Parse(InputPoder.text);

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Zona 1");
        }
    }

    void Cambiar()
    {
        camara.enabled = false;
    }

    void Habilitar()
    {
        camara.enabled = true;
    }
}
