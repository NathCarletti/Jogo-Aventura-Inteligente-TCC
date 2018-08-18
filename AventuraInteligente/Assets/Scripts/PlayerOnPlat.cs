using UnityEngine;
using System.Collections;

public class PlayerOnPlat : MonoBehaviour {
	public Transform player;
	public GameObject teste;
	//private ImagePosition;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
   /* void OnCollisionEnter2D(Collision2D colisor) {
        if (colisor.gameObject.tag == "Player")
        {
			player.position = new Vector3 (transform.position.x, transform.position.y+0.2f, transform.position.z);
        }
    }*/

    void OnCollisionStay2D(Collision2D colisor)
	{
        if (colisor.gameObject.name == "Player")
        {
			Debug.Log("oi");
			player.position = new Vector3 (transform.position.x, transform.position.y+0.275f, transform.position.z);
			teste.GetComponent<Player> ().Movimentacao();
        }
    }

    void OnCollisionExit2D(Collision2D colisor)
    {
        if (colisor.gameObject.name == "Player")
        {
			
        }
    }
}
