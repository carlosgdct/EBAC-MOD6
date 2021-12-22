using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_cubo1 : MonoBehaviour
{
    public GameObject PrefabCubo;
    bool variable1;
     
    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        //Color a = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = a;
        tempGameObject.transform.position = new Vector3(1, 1, 1);
    }
    // Start is called before the first frame update
    void Start()
    {       

    }

    // Update is called once per frame
    void Update()
    {
        variable1 = false;
        //GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        //tempGameObject.transform.position = new Vector3(Random.value, Random.value, Random.value);

        if (!variable1 == true)
        {
            GameObject tempGO = Instantiate<GameObject>(PrefabCubo);
            Color white = Color.white;
            tempGO.GetComponent<MeshRenderer>().material.color = white;
        }
        else
        {
            GameObject tempGO = Instantiate<GameObject>(PrefabCubo);
            Color black = Color.black;
            tempGO.GetComponent<MeshRenderer>().material.color = black;
        }
    }
}
//crea una variable booleana que se modifique cada FixedUpdate, si su valor era falso, vuélvelo verdadero y viceversa, pon el color del GO blanco cuando sea verdadero y negro cuando sea falso.