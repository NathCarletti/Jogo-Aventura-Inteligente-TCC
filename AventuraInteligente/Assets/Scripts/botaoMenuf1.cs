using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class botaoMenuf1 : MonoBehaviour {

	public Button btnmenuf1;
	// Use this for initialization
	void Start () {
		Button btnm = btnmenuf1.GetComponent<Button> ();
		btnm.onClick.AddListener (ClicaBotaoMenu);
	}

	// Update is called once per frame
	void Update () {

	}
	public void ClicaBotaoMenu(){
		SceneManager.LoadScene ("Menu");
	}
}
