using UnityEngine;

public class EASD : MonoBehaviour
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
    void FixedUpdate()
    {
        Vector3 velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = speed;
        }

        myRB.AddForce(velocity);
    }
}
