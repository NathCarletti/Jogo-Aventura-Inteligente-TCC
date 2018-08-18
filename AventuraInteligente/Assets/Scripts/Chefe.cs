using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Chefe : MonoBehaviour {
	public Transform player;

	private Rigidbody2D rb;
	public int cont;
    //private float x,y;
    private int coli;
	private int tempo=0;
	int toque;
	public int colic;
	// Use this for initialization
	void Start () {
		//target = GameObject.FindGameObjectWithTag ("Player").transform;
		colic = 0;
		rb = GetComponent<Rigidbody2D>();
		player = GetComponent<Transform> ().transform;
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			transform.gameObject.SetActive (false);
			other.transform.position = new Vector3 (54f, -1.21f, 0f);
			other.rigidbody.isKinematic = true;
			colic = 1;
		}

	}

}
