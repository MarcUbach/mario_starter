using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliderCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.gameObject.tag == "Platform")
		{
			coll.gameObject.GetComponent<MeshRenderer>().enabled = false;
			coll.gameObject.GetComponent<BoxCollider>().enabled = false;
			coll.gameObject.GetComponent<ParticleSystem>().Play();


		}

	}
}
