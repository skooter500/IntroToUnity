using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [Range(0, 100)]
    public float speed = 5.0f;

    [Range(0, 360)]
    public float rotSpeed = 360.0f;
    

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        //transform.Translate(0, 0, speed * Time.deltaTime);

        transform.Translate(0, 0, speed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0, rotSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0);

        if (Input.GetKey(KeyCode.Space))
        {
            GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab);
            bullet.transform.position = spawnPoint.position;
            bullet.transform.rotation = spawnPoint.rotation;
        }
    }
}
