using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_cápsula : MonoBehaviour
{
    public GameObject PrefabCapsule;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
    private void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCapsule);
        //Color a = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = a;
        tempGameObject.transform.position = new Vector3(Random.Range(4, 5), Random.Range(4, 5), Random.Range(4, 5));
    }
    private void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCapsule);
        //Color b = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = b;
        tempGameObject.transform.position = new Vector3(Random.Range(-2, 2), Random.Range(-3, 3), Random.Range(-1, -1));
    }
}
//cambiar tu primitiva 3 de color aleatoriamente en la funcion FixedUpdate; MeshRenderer().Material.color 
//crear un cubos en las funciones OnDisable() y OnEnable() Instantiate<>