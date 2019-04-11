using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravity = -9.8f;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (pos.y > 0)
        {
            speed += gravity * Time.deltaTime;
            pos.y += speed * Time.deltaTime;
            transform.position = pos;
            Debug.Log(Time.time);
        }
    }
}
