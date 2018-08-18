using UnityEngine;
using System.Collections;

public class AtivaChefe : MonoBehaviour {

	public bool conti=false;
	Transform player;


	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;

	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") { conti = true;
			GetComponent<BoxCollider2D> ().isTrigger = false;
			Debug.Log ("paredechefe");}

	}
}
