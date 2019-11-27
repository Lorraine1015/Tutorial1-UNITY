using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour
{
    //CAIDA DE ENEMIGOS

    public Transform prefab;
    public Transform prefab2;
    public Transform prefab3;
    
    public bool active;


    // Start is called before the first frame update
    void Start()
    {
        active = true;
        InvokeRepeating("Enemy", 0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Enemy()
    {
        if(active== true)//activado la produccion de meteoros
        { 
            int i = Random.Range(0,3);//Crea un numero aleatorio de 0-2
            if (i == 0)//si el numero es igual a 0
            {
                Instantiate(prefab, transform.position, Quaternion.identity);//crea un meteoro de color rojo

            }
            if (i == 1)
            {
                Instantiate(prefab2, transform.position, Quaternion.identity);//verde
            }
            if (i == 2)
            {
                Instantiate(prefab3, transform.position, Quaternion.identity);//azul
            }
            //Cambia la posicion de la aparicion de los meteoritos
            Vector3 position = transform.position;
            position.x = UnityEngine.Random.Range(-3, 3);
            transform.position = position;
            
        }
        if (active == false)
        {

        }
    }

}
