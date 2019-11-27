using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //MOVIMIENTO MEDIANTE TRANSLATE por medio de teclas

    //Crear un objeto en una escena
    public Transform prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si aprieta en tecla-espacio...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("michelle");//imprime
            Instantiate(prefab, transform.position, Quaternion.identity);//instantaneamente crea el prefab
        }
    }
    private void FixedUpdate()
    {
        //Se obtiene el movimiento de las teclas
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Se traslada respecto a las teclas
        gameObject.transform.Translate(new Vector3(horizontal, vertical, 0));//SE MUEVE EN X y Y,TRASLADO DE OBJETO SEGUN EL VECTOR
        Vector3 position = gameObject.transform.position;//SE DECLARA LA POSICION DEL OBJETO EN BASE AL VECTOR

    }
}

