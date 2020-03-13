using UnityEngine;
using UnityEngine.UI;

public class Racket : MonoBehaviour
{
    public string axisName = "Vertical1";
    public float moveSpeed = 10;
    public Text scoreText;

    public int Score { get; private set; }

    private void FixedUpdate()
    {
        float moveAxis = Input.GetAxis(axisName) * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveAxis); 
        
    }
    public void makeScore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }
}
