using UnityEngine;

public class AIRacket : Racket
{
    public Transform ball;

    protected override void MakeMove()
    {
        float distance = Mathf.Abs(ball.position.y - transform.position.y);
        if(distance>2)
        if (ball.position.y>transform.position.y)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * moveSpeed;

        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, - 1) * moveSpeed;

        }
    }
}
