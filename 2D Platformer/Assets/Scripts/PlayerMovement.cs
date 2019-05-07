using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    public float speed = 13;
    //public float rotateSpeed;
    //public float gravity;
    public bool grounded;
    public double J;
    public double boom;
    public Vector3 beep;
    Rigidbody2D rb2D;
    public float liftForce;
    public float floatHeight;
    public float damping;
    public float jumpHeight = 200;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
      
    
    }
     void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null)
        {
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            float heightError = floatHeight - distance;

            float force = liftForce * heightError - rb2D.velocity.y * damping;
            rb2D.AddForce(Vector3.up * force);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(Vector3.up * 2);// += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
		transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
        if (Input.GetKey(KeyCode.D))
        {
            transform.position+=(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
           // transform.Translate(Vector3.down * 2);
        }
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            /// transform.Translate(Vector3.up * 1);
            rb2D.AddForce(transform.up * jumpHeight);

            grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "ground") grounded = true;

        if (collision.collider.tag == "wall") grounded = true;
    

    }
}