using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    
    public Text text;
    private int puntos_inicial=0;
    

    //MOVIMIENTO MEDIANTE USO DE FISICA->FUERZAS
    Rigidbody rb;//RIGIDBODY ES UN COMPONENTE QUE CREA LA INTERACCION CON LA FISICA DEL OBJETO(GRAVEDAD,ETC)
    public float forceScalar = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();//SE DECLARA LA VARIABLE DEL COMPONENTE   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");//VARIABLE DE MOVIMIENTO HORIZONTAL
        float vertical = Input.GetAxis("Vertical");//VARIABLE DE MOVIMIENTO VERTICAL
        Vector3 movement = new Vector3(horizontal, 0, vertical);//EL MOVIMIENTO DEL VECTOR DONDE ESTA EL OBJETO
        rb.AddForce(movement * forceScalar);//SE LE AÑADE UNA FUERZA QUE EMPUJA AL OBJETO(MOVIMIENTO*FUERZAESCALAR)
    }

    private void OnCollisionEnter(Collision collision)//FUNCION DE COLISION
    {
        if (collision.gameObject.CompareTag("enemy"))//SI COLISIONA CON UN OBJETO DE TAG->ENEMY
        {
            Destroy(collision.gameObject);//SE DESTRUYE EL OBJETO
        }
    }

    private void OnTriggerEnter(Collider other)//SI COLISIONA CON UN OBJETO CON TRIGGER(NO SOLIDO)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;//EL OBJETO CAMBIARA DE COLOR
        //SUMA DE TOQUES CON EL OBJETO
        puntos_inicial += other.gameObject.GetComponent<Star>().num;//PUNTOS INICIAL= PUNTOS INICIAL + NUM
        text.text = "" + puntos_inicial;
      
       
    }
}
