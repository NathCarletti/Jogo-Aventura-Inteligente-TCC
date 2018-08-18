using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botaoFase1 : MonoBehaviour {
	public Button btnf1;
	// Use this for initialization
	void Start () {
		Button btnfa1 = btnf1.GetComponent<Button> ();
		btnfa1.onClick.AddListener (ClicaBotaoFase1);
	}

	// Update is called once per frame
	void Update () {

	}
	public void ClicaBotaoFase1(){
		SceneManager.LoadScene ("Fase1");
	}
}
