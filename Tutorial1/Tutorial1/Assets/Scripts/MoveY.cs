using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveY : MonoBehaviour
{
    public float movementY;//SE DECLARA UNA VARIABLE PUBLICA

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, movementY, 0));//SE MUEVE EN Y(arriba o abajo)
    }
}
