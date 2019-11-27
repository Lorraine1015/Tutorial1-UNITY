using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evaluacion : MonoBehaviour
{
    GameObject num1;
    GameObject num2;
    GameObject num3;
    GameObject num4;
    GameObject num5;
    GameObject num6;
    GameObject num7;
    GameObject num8;
    GameObject num9;
    GameObject num10;
    GameObject num11;
    GameObject num12;
    GameObject num13;
    GameObject num14;
    GameObject num15;
    GameObject message;
    public string final = "CONGRATULATIONS";
    public string gameover = "ORDEN INCORRECTO";
    // Start is called before the first frame update
    void Start()
    {
        num1 = GameObject.Find("1-15");
        num2 = GameObject.Find("2-15");
        num3 = GameObject.Find("3-15");
        num4 = GameObject.Find("4-15");
        num5 = GameObject.Find("5-15");
        num6 = GameObject.Find("6-15");
        num7 = GameObject.Find("7-15");
        num8 = GameObject.Find("8-15");
        num9 = GameObject.Find("9-15");
        num10 = GameObject.Find("10-15");
        num11 = GameObject.Find("11-15");
        num12 = GameObject.Find("12-15");
        num13 = GameObject.Find("13-15");
        num14 = GameObject.Find("14-15");
        num15 = GameObject.Find("15-15");
        message = GameObject.Find("error");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()//EVALUA EL ORDEN DEL TABLERO
    {
        if (num1.gameObject.GetComponent<Transform>().position == new Vector3(-2.5f, 2.5f, 0) &&
            num2.gameObject.GetComponent<Transform>().position == new Vector3(-1f, 2.5f, 0) &&
            num3.gameObject.GetComponent<Transform>().position == new Vector3(.5f, 2.5f, 0) &&
            num4.gameObject.GetComponent<Transform>().position == new Vector3(2f, 2.5f, 0) &&

            num5.gameObject.GetComponent<Transform>().position == new Vector3(-2.5f, 1f, 0) &&
            num6.gameObject.GetComponent<Transform>().position == new Vector3(-1f, 1f, 0) &&
            num7.gameObject.GetComponent<Transform>().position == new Vector3(.5f, 1f, 0) &&
            num8.gameObject.GetComponent<Transform>().position == new Vector3(2f, 1f, 0) &&

            num9.gameObject.GetComponent<Transform>().position == new Vector3(-2.5f, -.5f, 0) &&
            num10.gameObject.GetComponent<Transform>().position == new Vector3(-1f, -.5f, 0) &&
            num11.gameObject.GetComponent<Transform>().position == new Vector3(.5f, -.5f, 0) &&
            num12.gameObject.GetComponent<Transform>().position == new Vector3(2f, -.5f, 0) &&

            num13.gameObject.GetComponent<Transform>().position == new Vector3(-2.5f, -2f, 0) &&
            num14.gameObject.GetComponent<Transform>().position == new Vector3(-1f, -2f, 0) &&
            num15.gameObject.GetComponent<Transform>().position == new Vector3(.5f, -2f, 0) )//CONDICIONES DE POSICION DE CADA NUM
        {
            message.GetComponent<Text>().text = final;//MENSAJE DE ORDEN CORRECTO
        }
        else
        {
            message.GetComponent<Text>().text = gameover;//MENSAJE DE ORDEN INCORRECTO
        }
    }
}
