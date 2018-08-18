using UnityEngine;
using System.Collections;

public class BolaDeFogo : MonoBehaviour {
	public GameObject plat1;
	public GameObject plat2;
	public GameObject plat3;
	public GameObject plat4;
	public GameObject plat5;
	public GameObject ativPC1;
	public GameObject ativPC2;
	public GameObject objeto5;
	public GameObject texto;
	private AtivaChefe ativC;
	public Transform target;

	public Transform chefe;
	private Rigidbody2D rb;
	public int cont;
	//private float x,y;
	private int coli;
	private int tempo=0;
	int toque;
	bool j;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		chefe = GameObject.FindGameObjectWithTag ("chefe").transform;
		ativC = objeto5.GetComponent<AtivaChefe> ();
		rb = GetComponent<Rigidbody2D>();
		plat1.SetActive (false);
		plat2.SetActive (false);
		plat3.SetActive (false);
		plat4.SetActive (false);
		plat5.SetActive (false);
		ativPC1.SetActive (false);
		ativPC2.SetActive (false);
		texto.SetActive (false);
		j = false;
	}

	// Update is called once per frame
	void Update () {
		if (ativC.conti==true && (cont>=0&&cont<6)) {
			tempo = tempo + 1;
			if (tempo < 180 && j==false) {
				texto.SetActive (true);
				j = true;
			}
			if (tempo ==180 && j ==true) {
				texto.SetActive (false);
				//rotacao
				transform.position = new Vector3 (target.position.x, target.position.y + 5.6f, target.position.z);
				rb.isKinematic = false;
				Debug.Log ("bola de fogo");
				tempo = 0;
				cont++;
			}
		}
			if (cont >= 6) {
				tempo = 200;
				
				//chefe.transform.position = new Vector3 (-3.84f, -1.0f, 0f);
				//chefe.position = new Vector3 (-3.84f, -1.0f, 0f);
				//chefe.position = new Vector3 (-3.84f, -1.0f, 0f);
				transform.gameObject.SetActive (false);
				ativPC1.SetActive (true);
				ativPC2.SetActive (true);
				plat1.SetActive (true);
				plat2.SetActive (true);
				plat3.SetActive (true);
				plat4.SetActive (true);
				plat5.SetActive (true);
			}
			if (coli == 1) {
				rb.isKinematic = true;
				//rotaciona
				transform.position = new Vector3 (chefe.position.x, chefe.position.y + 0.5f, chefe.position.z);
				coli = 0;
				
			}
		} 


	void OnCollisionStay2D(Collision2D other){
		if (other.gameObject.tag == "chao") {
			coli=1;
		}

	}

}
