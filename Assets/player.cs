using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update

    bool right = false;

    Vector2 bulletFacing = new Vector2(1, 0);


    private Rigidbody2D rb;

    private SpriteRenderer sprite;

    public GameObject bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey("a") )

        {

        Vector2 left = new Vector2(-20, 0);

        rb.AddForce(left);
        }

        if (Input.GetKeyDown("space"))

       {Instantiate(bullet, gameObject.transform.position + (Vector3)bulletFacing, Quaternion.identity).GetComponent<Bullet>().right = right;

         }if(Input.GetKey("d") )

        {

        Vector2 right = new Vector2(20, 0);

        rb.AddForce(right);

        }

        if(Input.GetKey("w") )

        {

        Vector2 up = new Vector2(0, 20);

        rb.AddForce(up);

        }
        CheckVelocity();

        if (right == true)
        {
            sprite.flipX = false;
        }
        else
        {
            sprite.flipX = true;
        }

    }

    void CheckVelocity()
    {

        Vector2 velocity = rb.velocity;

        if (velocity.x > 0)
        {
            right = true;
            bulletFacing = new Vector2(1, 0);
        }

        if (velocity.x < 0)
        {
            right = false;
            bulletFacing = new Vector2(-1, 0);
        }

    }
}
