using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    
    GameObject Space;
    GameObject Error;
    private float distance;
    public string nota = "ERROR:SOLO SE PUEDE MOVER A FICHAS VECINAS";

    // Start is called before the first frame update
    void Start()
    {
        Space = GameObject.Find("space");//Busca el espacio
        Error = GameObject.Find("error");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()//AL HACER CLIC MOVIMIENTO DEL NUM AL ESPACIO
     {
        Vector3 position_num = gameObject.transform.position;//POSICION ACTUAL DEL NUMERO
        Vector3 position_space = Space.GetComponent<Transform>().position;//POSICION ACTUAL DEL ESPACIO
        distance = Vector3.Distance(position_num, position_space);//DISTANCIA ENTRE EL NUM Y EL ESPACIO

        if (distance <= 1.5)//SOLO SE PUEDE MOVER SI LA DISTANCIA ENTRE EL NUM Y EL ESPACIO NO SUPERA EL 1.5
        {
            //Debug.Log(distance);IMPRIME EL TEXTO
            Space.GetComponent<Transform>().position = position_num;//CAMBIA LA POSICION DEL ESPACIO POR EL DEL NUM
            gameObject.GetComponent<Transform>().position = position_space;//CAMBIA LA POSICION DEL NUM POR EL DEL ESPACIO
            Vector3 position_actual = gameObject.transform.position;
         }
        else
        {
            Error.GetComponent<Text>().text = nota;//APARECE MENSAJE de ERROR
        }

     }

}

