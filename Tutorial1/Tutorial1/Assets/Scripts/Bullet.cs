using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //COMPORTAMIENTO DE LA BALA (ESFERA)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)//FUNCION DE AL ENTRAR UNA COLISION
    {
        Destroy(collision.gameObject);//Destruye el objeto con el cual colisiona
    }
}
