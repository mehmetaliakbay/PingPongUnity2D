using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb2;
    public float moveSpeed=10;
    public Racket leftRacket, rightRacket;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        rb2.velocity = new Vector2(1, 0) * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TagManager tagManager = collision.gameObject.GetComponent<TagManager>();

        GetComponent<AudioSource>().Play();

        if(tagManager == null)
        {
            return;
        }
        Tag myTag = tagManager.myTag;
        if(myTag.Equals(Tag.SOL_DUVAR))
        {
            //sag player skor yapar
            rightRacket.makeScore();
        }
        else if (myTag.Equals(Tag.SAG_DUVAR))
        {
            //sol player skor yapar
            leftRacket.makeScore();
        }
        if (myTag.Equals(Tag.SAG_DUVAR))
        {
            DonusYonHesapla(collision,-1);

        }
        else if (myTag.Equals(Tag.SOL_DUVAR))
        {
            DonusYonHesapla(collision, 1);

        }
    }

    private void DonusYonHesapla(Collision2D collision,int x)
    {
        float a = transform.position.y - collision.gameObject.transform.position.y;
        float b = collision.collider.bounds.size.y;
        float y = a / b;
        rb2.velocity = new Vector2(x, y) * moveSpeed;
    }
}
