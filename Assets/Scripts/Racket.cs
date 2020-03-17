using UnityEngine;
using UnityEngine.UI;

public abstract class Racket : MonoBehaviour
{

    public float moveSpeed = 10;
    public Text scoreText;

    public int Score { get; private set; }

    private void FixedUpdate()
    {
        MakeMove();
    }

    protected abstract void MakeMove();

    public void MakeScore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }
}
