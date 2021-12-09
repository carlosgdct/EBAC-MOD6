using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variableA;
    bool variableB;
    bool variableC;

    int valor1 = 5;
    int limiteInferior = -5;
    int limiteSuperior = 5;
    enum selecciónColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }

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
        valor1 = Random.Range(limiteSuperior, limiteInferior);
        Debug.Log(valor1);

        //if (valor1 >= 0)
        //{
        //    Debug.Log("El valor es positivo");
        //}
        //else
        //{
        //    Debug.Log("El valor es negativo");
        //}

        string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es negativo";
        Debug.Log(resultado);

        //switch (valor1)
        //{
        //    case (int) selecciónColor.rojo:
        //        Debug.Log("El color seleccionado es rojo");
        //        break;
        //    case (int) selecciónColor.verde:
        //        Debug.Log("El color seleccionado es verde");
        //        break;
        //    case (int) selecciónColor.azul:
        //        Debug.Log("El color seleccionado es azul");
        //        break;
        //    case (int) selecciónColor.blanco:
        //        Debug.Log("El color seleccionado es blanco");
        //        break;
        //    case (int) selecciónColor.gris:
        //        Debug.Log("El color seleccionado es gris");
        //        break;
        //    default:
        //        Debug.Log("Este no es un color válido");
        //        break;
        //}

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
