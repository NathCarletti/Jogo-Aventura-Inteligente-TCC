using UnityEngine;
using System.Collections;

public class Portais2 : MonoBehaviour
{
	public Transform player;
	public GameObject ativa;
	private AtivaPortal ap;
	public int port;

	void Start(){
		ap = ativa.GetComponent<AtivaPortal>();
		player = GameObject.FindGameObjectWithTag("Player").transform;

	}

	void OnTriggerStay2D(Collider2D other)
	{


		if (other.gameObject.tag == "Player") {
			if (gameObject.tag == "portal1") {
				port = 1;
			}
			if (gameObject.tag == "portal2") {
				port = 2;
			}
		}
		if (((Input.GetKeyDown (KeyCode.E)) && port == 1 && ap.portalO) ||
			((Input.GetKeyDown (KeyCode.E)) && port == 2 && ap.portalT)) {
			player.transform.position = new Vector3 (-6, 4.5f, 0);
		} else if (((Input.GetKeyDown (KeyCode.E)) && port == 1 && !ap.portalO) ||
			((Input.GetKeyDown (KeyCode.E)) && port == 2 && !ap.portalT)) {
			player.transform.position = new Vector3 (10,0.5f,0);
		}
		//puxa vdd ou falso de ativ port
	}
}
