using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform followTarget;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = followTarget.position;
        transform.position = new Vector3(currentPosition.x, currentPosition.y, transform.position.z);
    }
}
