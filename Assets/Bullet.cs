using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool right;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       float direction;
        if (right)
        {
            direction = 0.1f;
        }
        else
        {
            direction = -0.1f;
        }
        float x = gameObject.transform.position.x + direction;
        float y = gameObject.transform.position.y;
        float z = gameObject.transform.position.z;
        gameObject.transform.position = new Vector3(x, y, z);
    }
}
