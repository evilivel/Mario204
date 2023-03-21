using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    
    private Rigidbody2D body;
    private BoxCollider2D collider;

    private float moveSpeed = 5f;
    private float jumpForce = 10f;
    public bool isGrounded = false;
    public Transform groundCheck;


    // Start is called before the first frame update
    void Start()
    {
       body = gameObject.GetComponent<Rigidbody2D>();
       collider = gameObject.GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //2d platformer charecter controller useinf wasd and sapce bar for controlls

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        //check if colliding with ground



        
    }
}
