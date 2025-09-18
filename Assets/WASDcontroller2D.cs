using UnityEngine;

public class WASDcontroller2D : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 20f;
    public Rigidbody2D myRB;

    public bool jumped = false;
    public bool grounded = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && grounded)
        {
            jumped = true;
        }
    }

    //Fixed Update is called once per physics step
    void FixedUpdate()
    {

        //let's start with a simple WASD controller
        Vector3 velocity = Vector3.zero;

        /*if (Input.GetKey(KeyCode.W))
        {
            velocity.y = speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -speed;
        }*/

        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = speed;
        }
        myRB.AddForce(velocity);


        //when player presses space, jump
        if (jumped)
        {
            Jump();
            jumped = false;
        }
    }


    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject);
        grounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Stopped Colliding with: " + collision.gameObject);
        grounded = false;
    }

    //you can write your own custom functions to execute specific actions or tasks
    void Jump()
    {
        myRB.AddForce(Vector3.up * jumpForce);
    }


}
