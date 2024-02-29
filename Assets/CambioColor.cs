using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{

    public GameObject cube;
    public GameObject esfera;
    public GameObject cilindro;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        esfera = GameObject.Find("Sphere");
        cilindro = GameObject.Find("Cylinder");

        cube.GetComponent<MeshRenderer>().material.color = Color.black;
        esfera.GetComponent<MeshRenderer>().material.color = Color.blue;
        cilindro.GetComponent<MeshRenderer>().material.color = Color.grey;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
