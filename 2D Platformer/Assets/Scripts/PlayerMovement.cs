using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public float speed;
    public float rotateSpeed;
    public float jumpingHeight;
    // Start is called before the first frame update
    void Start()
    {
        jumpingHeight = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 10);// += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
            {
            transform.position += transform.up * jumpingHeight * Time.deltaTime;
           }
    }
}