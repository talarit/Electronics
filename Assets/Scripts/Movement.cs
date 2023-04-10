using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 direction;
    private int d = 0;
    public Count count;
    private bool Pr = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Sq1")
        {
            d = 1;
        }

        if (collision.gameObject.tag == "Sq2")
        {
            d = 2;
        }
        if (collision.gameObject.tag == "Breaker")
        {
            Destroy(gameObject);
           count.Health--;
        }
        if (Pr == true)
        {
            if (collision.gameObject.tag == "Basket")
            {
                count.Score++;
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Sq1")|| (collision.gameObject.tag == "Sq2"))
        {
            d = 0;
            Pr = false;
        }
    }

    private void FixedUpdate()
    {
        if (d==1)
        {
            this.transform.Translate(0.05f,-0.05f,0);
        }
        if (d==2)
        {
            this.transform.Translate(-0.05f, -0.05f, 0);
        }
        if(d==0)
        {
            this.transform.Translate(0, -0.2f, 0);
        }
    }
}
