using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_2 : MonoBehaviour
{
    public GameObject PrefabSphere;
    public int numSpheres = 0;
    bool variable1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        variable1 = true;
        if (variable1 == true)
        {
            GameObject tempGO = Instantiate<GameObject>(PrefabSphere);
            Color white = Color.black;
            tempGO.GetComponent<MeshRenderer>().material.color = white;
        }
        numSpheres++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabSphere);
        tempGameObject.name = "SphereNum" + numSpheres;
        //Color b = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = b;
        tempGameObject.transform.position = new Vector3(Random.Range(0, 6), Random.Range(1, 6), Random.Range(2, 5));

      
    }
}
//cambiar tu primitiva 2 de color aleatoriamente en la funcion Update; MeshRenderer().Material.color 
//crear muchos cubos en la funcion Update Instantiate<>