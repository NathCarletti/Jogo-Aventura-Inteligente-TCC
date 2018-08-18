using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
	public Button btnjogar;
	public Button btncred;
	public Button btnsair;
	//public Button btnmenu;


	// Use this for initialization
	void Start () {
		Button btnj = btnjogar.GetComponent<Button> ();
		Button btnc = btncred.GetComponent<Button> ();
		Button btns = btnsair.GetComponent<Button> ();
		//Button btnm = btnmenu.GetComponent<Button> ();
		btnj.onClick.AddListener (ClicaBotaoJogar);
		btnc.onClick.AddListener (ClicaBotaoCreditos);
		btns.onClick.AddListener (ClicaBotaoSair);
		//btnm.onClick.AddListener (ClicaBotaoMenu);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClicaBotaoJogar(){
		SceneManager.LoadScene ("Historia");
	}
	public void ClicaBotaoSair(){
		Application.Quit();
	}
	public void ClicaBotaoCreditos(){
		SceneManager.LoadScene ("Creditos");
	}
}
