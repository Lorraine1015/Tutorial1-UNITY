using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int puntos = 0;
    public string bienjuego = "CONGRATULATIONS";
    GameObject Message;
    GameObject Creador;
    

    // Start is called before the first frame update
    void Start()
    {
       Message = GameObject.Find("FinalMessage");
       Creador = GameObject.Find("Creadordemeteoros");//SCRIPT METEORO
    }

    // Update is called once per frame
    void Update()
    {
      
        if (puntos >= 5)
        {
            Message.GetComponent<Text>().text = bienjuego;//APARECE MENSAJE
            Creador.GetComponent<Meteoro>().active = false;//DESACTIVAMOS EL SCRIPT DE METEOROS
        }
        gameObject.GetComponent<Text>().text = puntos.ToString();//APARECEN LOS PUNTOS ACUMULADOS
    }

}
