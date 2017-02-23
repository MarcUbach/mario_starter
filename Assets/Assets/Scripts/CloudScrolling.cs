using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScrolling : MonoBehaviour
{

    public float scrollingSpeed;
    public float loopArroundPosition;
    public float endPosition;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * scrollingSpeed);

        if (transform.position.x >= endPosition)
        {
            Vector3 position = transform.position;
            position.x = loopArroundPosition;
            transform.position = position;

        }
    }
}
