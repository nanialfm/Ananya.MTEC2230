using UnityEngine;
using TMPro;

public class GameMAnager : MonoBehaviour
{
    public float timer;
    public float gameTimeLimit = 30f;
    public float timeLeft;
    public TextMeshProUGUI myText;
    public GameObject myPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame;
    void Update()
    {
        //Time.deltaTime is the amount of time that has
        //passed since the last frame
        timer += Time.deltaTime;
        timeLeft = gameTimeLimit - timer;

        if (timeLeft <= 0)
        {
            //end the game
            Destroy(myPlayer);
            Debug.Log("Game Over!");

            ;
        }

        myText.text = timeLeft.ToString();
    }

    void FixedUpdate()
    {
        //Time.fixedDeltaTime is the amount of time that has
        //passed since the last physics step
        float delta = Time.fixedDeltaTime;
    }
}