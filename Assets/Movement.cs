using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject cube;
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
        EsferaHija();
    }

    private void EsferaHija()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Escala();
        Rotacion();
    }

    private void Movimiento()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {       
            cube.transform.position += Vector3.forward * speed;           
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cube.transform.position += Vector3.back * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            cube.transform.position += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            cube.transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            cube.transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            cube.transform.position += Vector3.down * speed;
        }
    }

    private void Escala()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            cube.transform.localScale += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            cube.transform.localScale += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            cube.transform.localScale += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            cube.transform.localScale += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            cube.transform.localScale += Vector3.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            cube.transform.localScale += Vector3.back * speed;
        }
    }
    private void Rotacion()
    {
        transform.rotation *= Quaternion.Euler(0, 1 * speed, 0);
    }
}
