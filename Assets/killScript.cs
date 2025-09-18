using UnityEngine;

public class killScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisonEnter2D(Collision2D other)
    {
        //Destroy(player);

        //if (play collides with NS Ground <= 0)
        {
            //end the game
            Destroy(myPlayer);
            Debug.Log("Try Again!");

        }

    }
}
