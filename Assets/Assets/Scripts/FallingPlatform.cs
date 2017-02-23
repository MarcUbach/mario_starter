using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour
{

    public float delayTime;

    private bool steppedOn;

    private Rigidbody rigidBody;

    private Vector3 originalPosition;

    private float timer;

    void Start()
    {
        timer = delayTime;
        steppedOn = false;
        originalPosition = transform.position;

        rigidBody = GetComponent<Rigidbody>();
        rigidBody.isKinematic = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            steppedOn = true;
        }
    }

    void Update()
    {
        if (steppedOn)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                rigidBody.useGravity = true;
                rigidBody.isKinematic = false;

            }
        }
    }

    public void Respawn()
    {
        transform.position = originalPosition;
        steppedOn = false;
        rigidBody.velocity = Vector3.zero;
        rigidBody.useGravity = false;
        rigidBody.isKinematic = true;
        timer = delayTime;
    }

}