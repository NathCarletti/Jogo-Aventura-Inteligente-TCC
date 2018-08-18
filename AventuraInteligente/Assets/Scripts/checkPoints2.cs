using UnityEngine;
using System.Collections;

public class checkPoints2 : MonoBehaviour {

	public bool conti=false;
    Transform player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.tag == "Player") { conti = true; }

    }
}
