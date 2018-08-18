using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botaoCredito : MonoBehaviour {
	public Button btnmenu;
	// Use this for initialization
	void Start () {
		Button btnm = btnmenu.GetComponent<Button> ();
		btnm.onClick.AddListener (ClicaBotaoMenu);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ClicaBotaoMenu(){
		SceneManager.LoadScene ("Menu");
	}
}
