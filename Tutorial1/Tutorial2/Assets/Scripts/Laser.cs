using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public float movementY;
    public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, movementY));
    }
    private void OnCollisionEnter2D(Collision2D collision)//FUNCION DE COLISION
    {
        if (collision.gameObject.CompareTag("enemy"))//SI COLISIONA CON UN OBJETO DE TAG->ENEMY
        {
            if (collision.gameObject.GetComponent<Meteorito>().id==id )//SI COLISIONA CON UN OBJETO con el mismo id del laser
            {
                Destroy(collision.gameObject);//SE DESTRUYE EL OBJETO
                GameObject Score = GameObject.Find("score");
                Score.GetComponent<Score>().puntos += 1;
            }

            Destroy(gameObject);
        }
      
        
    }
}
