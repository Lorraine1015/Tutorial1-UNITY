using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //MOVIMIENTO MEDIANTE USO DE POSICIONES por medio de una variable

    public float movementX;//SE DECLARA UNA VARIABLE PUBLICA
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //IMPRIME EL NOMBRE  Debug.Log("Michelle");
        gameObject.transform.Translate(new Vector3(movementX, 0, 0));//SE MUEVE EN X,TRASLADO DE OBJETO SEGUN EL VECTOR
        Vector3 position = gameObject.transform.position;//SE DECLARA LA POSICION DEL OBJETO EN BASE AL VECTOR
        if (position.x > 3)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;//CAMBIO DE COLOR EN EL OBJETO
            //movementX = 0;//SE DETIENE EL OBJETO
            movementX = -movementX;//SE MUEVE LADO CONTRARIO
        }
        else if (position.x < -3 && movementX < 0)//AL LLEGAR A TAL CONDICION ,SE VUELVE A MOVER A LA DERECHA
        {
            movementX *= -1;
        }
   
    }
}
