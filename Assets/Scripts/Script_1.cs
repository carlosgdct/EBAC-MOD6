using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_1 : MonoBehaviour
{
    public GameObject PrefabCubo;
     
    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        Color a = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = a;
        tempGameObject.transform.position = new Vector3(1, 1, 1);
    }
    // Start is called before the first frame update
    void Start()
    {       

    }

    // Update is called once per frame
    void Update()
    {

    }
}
//cambiar de color tu primitiva 1 de manera aleatoria en Awake; MeshRenderer().Material.color 
//crear un cubo en la funcion Awake Instantiate<>