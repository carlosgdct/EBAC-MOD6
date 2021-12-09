using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variableA;
    bool variableB;
    bool variableC;

    int valor1 = 5;

    // A B C    ||  &&  ((A||B)&&C)     ((A||B)||C)
    // 1 1 1    1   1   1               1
    // 1 1 0    1   0   0               1
    // 1 0 1    1   0   1               1
    // 1 0 0    1   0   0               1
    // 0 1 1    1   0   1               1
    // 0 1 0    1   0   0               1
    // 0 0 1    0   0   0               1
    // 0 0 0    0   0   0               0

    // Start is called before the first frame update
    void Start()
    {
        variableA = false;
        variableB = false;
        variableC = false;

        if ((variableA || variableB) && variableC)
        {
            Debug.Log("La operación 1 es VERDADERO");
        }
        else if ((variableA||variableB)||variableC)
        {
            Debug.Log("La operación 2 es VERDADERO");
        }
        else if ((variableC && variableB) || variableA)
        {
            Debug.Log("La operación 3 es VERDADERO");
        }

        //variable1 = true;
        //Debug.Log(variable1);
        //if (variable1 == true)
        //{
        //    Debug.Log("Esta variable es verdadera");
        //    Debug.Log("Ya teienes el valor de variable 1");
        //}
        //if (valor1 < 5)
        //{
        //    Debug.Log("El valor de la variable es menor a 5");
        //}
        //if (valor1 <= 5)
        //{
        //    Debug.Log("El valor de la variable es menor o igual a 5");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
