using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()//FUNCION AL HACER CLIC EN EL OBJETO
    {
        Debug.Log("Michelle");//IMPRIME EL TEXTO
        gameObject.GetComponent<Renderer>().material.color = color;//CAMBIA EL COLOR DEL OBJETO
    }
}
