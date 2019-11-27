using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    GameObject Puntos;
    GameObject HitPoints;
    GameObject Nave;
    GameObject Creador;
    GameObject Message;
    // Start is called before the first frame update
    void Start()
    {
        Puntos = GameObject.Find("score");
        HitPoints = GameObject.Find("jugador");
        Nave = GameObject.Find("jugador");
        Creador = GameObject.Find("Creadordemeteoros");//SCRIPT METEORO
        Message = GameObject.Find("FinalMessage"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnMouseDown()
    {
        Puntos.GetComponent<Score>().puntos = 0;//REINICIA PUNTOS
        HitPoints.GetComponent<Nave>().HP = 10;//REINICIA HITPOINTS
        Nave.GetComponent<Transform>().position=new Vector3(0.03f,-2.03f,0f);//REINICIA POSICION
        Creador.GetComponent<Meteoro>().active = true;//ACTIVAMOS EL SCRIPT DE METEOROS
        Message.GetComponent<Text>().text = ""; //DESAPARECE MENSAJE DE GAME OVER
        
    }
}

