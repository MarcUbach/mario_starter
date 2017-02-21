using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 OrigPos;
    public Transform player;
	// Use this for initialization
	void Start ()
	{
	    OrigPos = transform.position;

	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.position = player.position + OrigPos;

	}
}
