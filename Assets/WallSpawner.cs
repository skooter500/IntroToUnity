using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public int width = 5;
    public int height = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = transform.position + new Vector3(col, row, 0);
                cube.GetComponent<Renderer>().material.color =
                    Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
                cube.AddComponent<Rigidbody>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
