using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caida : MonoBehaviour
{
    //FUNCION DE CAIDA DE LOS OBJETOS(ENEMIGOS)

    //CREA UN PREFAB
    public Transform prefab;

    // Start is called before the first frame update
    void Start()
    {
        //INVOCA LA REPETICION UNA FUNCION(NOMBRE DE LA FUNCION,DESDE QUE TIEMPO INICIA,CADA CUANTO SE REPITE)
        InvokeRepeating("Spawn", 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void Spawn()//FUNCION QUE DECLARAMOS 
    {
        Instantiate(prefab, transform.position, Quaternion.identity);//crea el objeto
        Vector3 position=transform.position;//Se crea un vector con la posicion del objeto creado
        position.x = UnityEngine.Random.Range(-3, 3);//se delcara una posicion en x con un rango de -3 a 3
        transform.position = position;//se sustituye la posicion del objeto por la posicion de x
    }
}
