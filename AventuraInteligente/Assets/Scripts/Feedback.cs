using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Feedback : MonoBehaviour {

	public List<string>feedbackC;
	public List<string>feedbackE;
	public GameObject ap;
	public GameObject cont;
	public GameObject tp1;
	public GameObject tp2;
	public GameObject tp3;
	public GameObject tp4;
	public GameObject tp5;
	public GameObject tp6;
	public GameObject pt1;
	public GameObject cf;
	public GameObject pt2;
	public GameObject player;
	public Text certaT1;
	public Text certaT2;
	public Text certaT3;
	public Text certaT4;
	public Text erradaT1;
	public Text erradaT2;
	public Text erradaT3;
	public Text erradaT4;

	public Plataforma plat1;
	public Plataforma plat2;
	public Plataforma plat3;
	public Plataforma plat4;
	public Plataforma plat5;
	public Plataforma plat6;
	public AtivaPortal port1;
	public AtivaPortal port2;
	public Chefe chefe;

	public GameObject titulo;
	public GameObject gameOver;
	public GameObject parabens;
	public GameObject certa1;
	public GameObject errada1;
	public GameObject certa2;
	public GameObject errada2;
	public GameObject certa3;
	public GameObject errada3;
	public GameObject certa4;
	public GameObject botao;
	public GameObject pMorto;
	public GameObject bmenu;
	public GameObject errada4;


	int i, bahia=0;


	// Use this for initaialization
	void Start () {
		//player = GetComponent<GameObject> ();
		cont = GameObject.Find ("Player");
		/*feedbackE.Add(ap.GetComponent<Plataforma> ().PE);
		feedbackC.Add (ap.GetComponent<Plataforma> ().PC);*/
		i = cont.GetComponent<lavaP> ().contador;
		plat1 = tp1.GetComponent<Plataforma> ();
		plat2 = tp2.GetComponent<Plataforma> ();
		plat3 = tp3.GetComponent<Plataforma> ();
		plat4 = tp4.GetComponent<Plataforma> ();
		plat5 = tp5.GetComponent<Plataforma> ();
		plat6 = tp6.GetComponent<Plataforma> ();
		port1 = pt1.GetComponent<AtivaPortal> ();
		port2 = pt2.GetComponent<AtivaPortal> ();
		chefe = cf.GetComponent<Chefe> ();
		titulo.SetActive (false);
		gameOver.SetActive (false);
		parabens.SetActive (false);
		certa1.SetActive (false);
		errada1.SetActive (false);
		certa2.SetActive (false);
		errada2.SetActive (false);
		certa3.SetActive (false);
		errada3.SetActive (false);
		certa4.SetActive (false);
		errada4.SetActive (false);
		pMorto.SetActive (false);
		botao.SetActive (false);
		bmenu.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		if (cont.GetComponent<lavaP> ().contador != i) {
			i = cont.GetComponent<lavaP> ().contador;
			if (ap.tag == "AP1" || ap.tag == "AP2" || ap.tag == "AP3" || ap.tag == "AP4" || ap.tag == "AP5" || ap.tag == "AP6") {
				feedbackE.Add (ap.GetComponent<Plataforma> ().PE);
				feedbackC.Add (ap.GetComponent<Plataforma> ().PC);
			} else if (ap.tag == "APO1" || ap.tag == "APO2") {
				feedbackE.Add (ap.GetComponent<AtivaPortal> ().PE);
				feedbackC.Add (ap.GetComponent<AtivaPortal> ().PC);
			} else {
			}
			cont.GetComponent<lavaP> ().FB = false;
			plat1.gameObject.SetActive (true);
			plat2.gameObject.SetActive (true);
			plat3.gameObject.SetActive (true);
			plat4.gameObject.SetActive (true);
			plat5.gameObject.SetActive (true);
			plat6.gameObject.SetActive (true);
			port1.gameObject.SetActive (true);
			port2.gameObject.SetActive (true);
			bahia = bahia + 1;
		} 
		if (bahia == 4) {
			Debug.Log ("palavras");
			certaT1.text = feedbackC [0];
			certaT2.text = feedbackC [1];
			certaT3.text = feedbackC [2];
			certaT4.text = feedbackC [3];
			erradaT1.text = feedbackE [0];
			erradaT2.text = feedbackE [1];
			erradaT3.text = feedbackE [2];
			erradaT4.text = feedbackE [3];


			//errada1text = feedbackE[0];
			player.SetActive (false);
			pMorto.SetActive (true);
			bmenu.SetActive (true);
			titulo.SetActive (true);
			gameOver.SetActive (true);
			certa1.SetActive (true);
			errada1.SetActive (true);
			certa2.SetActive (true);
			errada2.SetActive (true);
			certa3.SetActive (true);
			errada3.SetActive (true);
			certa4.SetActive (true);
			errada4.SetActive (true);
			bmenu.SetActive (true);
		} else if (bahia == 3) {
			if (chefe.colic == 1) {
				Debug.Log ("palavras");
				certaT1.text = feedbackC [0];
				certaT2.text = feedbackC [1];
				certaT3.text = feedbackC [2];
				erradaT1.text = feedbackE [0];
				erradaT2.text = feedbackE [1];
				erradaT3.text = feedbackE [2];

				//errada1text = feedbackE[0];
				titulo.SetActive (true);
				parabens.SetActive (true);
				certa1.SetActive (true);
				errada1.SetActive (true);
				certa2.SetActive (true);
				errada2.SetActive (true);
				certa3.SetActive (true);
				errada3.SetActive (true);
				botao.SetActive (true);
			}
		} else if (bahia == 2) {
			if (chefe.colic == 1) {
				Debug.Log ("palavras");
				certaT1.text = feedbackC [0];
				certaT2.text = feedbackC [1];
				erradaT1.text = feedbackE [0];
				erradaT2.text = feedbackE [1];

				//errada1text = feedbackE[0];
				titulo.SetActive (true);
				parabens.SetActive (true);
				certa1.SetActive (true);
				errada1.SetActive (true);
				certa2.SetActive (true);
				errada2.SetActive (true);
				botao.SetActive (true);
			}
		} else if (bahia == 1) {
			if (chefe.colic == 1) {
				Debug.Log ("palavras");
				certaT1.text = feedbackC [0];
				erradaT1.text = feedbackE [0];

				//errada1text = feedbackE[0];
				titulo.SetActive (true);
				parabens.SetActive (true);
				certa1.SetActive (true);
				errada1.SetActive (true);
				botao.SetActive (true);
			}
		} else if (bahia == 0) {
			if (chefe.colic == 1) {
				parabens.SetActive (true);
				botao.SetActive (true);
			}
		} else {
		}
	}
}
