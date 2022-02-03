using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // this is a refrance to the RigidBody Component, so that we can control it from here..
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SideWayForce = 200f;
    public PlayerMovement movement;
    public Text scoreText, resultText;

    private int score;

    private void Start()
    {
        score = 0;
        SetScoreText();
    }


    // Use "FixedUpdate" every time you wonna mess with phisics..
    void FixedUpdate()
    {
        // "Iime.DeltaTime" is to adresse the differance of FPS on differance PCs ..

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("right"))
        {
            rb.AddForce(SideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce((-1) * SideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score++;
            SetScoreText();
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            SetWinText();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            SetLoseText();
        }
    }

    

    void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString() ;
    }
    void SetLoseText()
    {
        resultText.text = "GAME OVER ! ×_×";
    }
    void SetWinText()
    {
        resultText.text = "YOU WIN ! ^_^";
        ForwardForce = 0f;
        SideWayForce = 0f;
}

}