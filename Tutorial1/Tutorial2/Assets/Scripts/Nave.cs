using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nave : MonoBehaviour
{
    //----------VARIABLES-----------
    //Creacion de un laser en la escena
    public Transform sprite;
    public Transform sprite2;
    public Transform sprite3;
    public Transform contact;
    private int arma = 0;
    public string arma_select;
    //PUNTOS DE LA NAVE
    public int HP = 10;
    //MENSAJE DEL JUEGO FINALIZADO
    public string finjuego = "GAME OVER";
    //SE DECLARA COLOR EN ARMA
    public Color arma_color;
    //GAMEOBJECTS DE LA ESCENA 
    GameObject Arma;
    GameObject Color_Arma;
    GameObject HitPoints;
    GameObject Message;
    GameObject Creador;


    //-----------FUNCIONES------------

    // -----Start is called before the first frame update
    void Start()
    {
        Arma = GameObject.Find("arma");//Busca el objeto de arma
        Color_Arma = GameObject.Find("color-arma");//Busca el objeto de color arma
        HitPoints = GameObject.Find("HP");
        Message = GameObject.Find("FinalMessage");
        Creador = GameObject.Find("Creadordemeteoros");//SCRIPT METEORO
       
    }

    // ------Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))//Cambio de arma con tecla z
        {
            arma += 1;
            if (arma>2)
            {
                arma = 0;
            }

        }
        if (Input.GetKeyDown(KeyCode.Space))//Creacion de laser con barra espaciadora
        {
            if (arma == 0)
            {
                Instantiate(sprite, transform.position, Quaternion.identity);
                arma_select = "Red";//se le asigna el nombre del color al arma
                arma_color = new Color(255 ,0 ,0 );
            }
            if (arma == 1)
            {
                Instantiate(sprite2, transform.position, Quaternion.identity);
                arma_select = "Green";
                arma_color = new Color(0,255,0);
            }
            if (arma == 2)
            {
                Instantiate(sprite3, transform.position, Quaternion.identity);
                arma_select = "Blue";
                arma_color = new Color(0,0,255);
            }

        }
        if (HP <= 0)//FIN DE HIT POINTS NAVE
        {
            Message.GetComponent<Text>().text = finjuego;//APARECE MENSAJE de GAME OVER
            Creador.GetComponent<Meteoro>().active = false;//DESACTIVAMOS EL SCRIPT DE METEOROS
        }

            Arma.GetComponent<Text>().text = arma_select;//Entramos al componente de texto en el objeto y colocamos el arma que se selecciono
            Color_Arma.GetComponent<Image>().color = arma_color;
            HitPoints.GetComponent<Text>().text = HP.ToString();
             
    }
    //-------------FUNCION DE COLISION
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Meteorito>())//SI COLISIONA UN METEORITO CON LA NAVE
        {

            Destroy(collision.gameObject);//SE DESTRUYE EL OBJETO
            Instantiate(contact,transform.position, Quaternion.identity);//crea un efecto
            GameObject HitPoints = GameObject.Find("HP");//BUSCA EL TEXTO
            int v = HP -= 1;
            HitPoints.GetComponent<Text>().text = v.ToString();//DISMINUYE EL HP 
        }
    }
    //------Movimiento por medio de teclas
    private void FixedUpdate()
    {
        //obtencion del movimiento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //se traslada el objeto 
        gameObject.transform.Translate(new Vector3(horizontal, vertical));
        Vector3 position = gameObject.transform.position;
    }
}
