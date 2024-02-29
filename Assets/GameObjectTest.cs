using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTest : MonoBehaviour
{
    public GameObject cube;

    private Transform transformacion;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        transformacion = cube.GetComponent<Transform>();     
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
    }

    private void LogPosition()
    {
        Debug.LogFormat("La transformacion del objeto en x es: {0}", transformacion.localPosition.x);
        Debug.LogFormat("La transformacion del objeto en y es: {0}", transformacion.localPosition.y);
        Debug.LogFormat("La transformacion del objeto en z es: {0}", transformacion.localPosition.z);
    }
}
