using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botaoFase2 : MonoBehaviour {

	public Button btnf2;
	// Use this for initialization
	void Start () {
		Button btnfa2 = btnf2.GetComponent<Button> ();
		btnfa2.onClick.AddListener (ClicaBotaoFase2);
	}

	// Update is called once per frame
	void Update () {

	}
	public void ClicaBotaoFase2(){
		SceneManager.LoadScene ("fase2");
	}
}

