using UnityEngine;
using System.Collections;

public class FlechaDeLadinho : MonoBehaviour {
    private BoxCollider2D fisica;
    private bool flag;
    public bool Entrada;
    public GameObject EntradaArmadilha;
    public GameObject SaidaArmadilha;
    public GameObject parede;
    //Rigidbody2D rigidbody;
    // Use this for initialization
    void Start () {
        fisica = GetComponent<BoxCollider2D>();
        flag = false;
    }
	// Update is called once per frame
	void Update () {
        //Entrada = EntradaArmadilha.GetComponent<Bloqueio>().AcionaTempo;
        if (Bloqueio2.tempo < 0 && !flag)
        {
            if(gameObject.tag == "Arrow2" || gameObject.tag == "Arrow6")
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector3(-150.0f, 0f, 0f));
            }
            if (gameObject.tag == "Arrow4" || gameObject.tag == "Arrow8")
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector3(150.0f, 0f, 0f));
            }
            flag = true;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Parede" || other.gameObject.tag == "Roof")
        {
            fisica.isTrigger = true;
        }
        if (other.gameObject.tag == "TesteDoPlayer")
        {
            Debug.Log("Colidiu com o player a flecha de lado");
            if (gameObject.tag == "Arrow2")
            {
                SaidaArmadilha = GameObject.Find("Chão2");
                EntradaArmadilha = GameObject.Find("EntradaArmadilha2");
                parede = GameObject.Find("Parede");
            }
            if (gameObject.tag == "Arrow4")
            {
                SaidaArmadilha = GameObject.Find("Chão3");
                EntradaArmadilha = GameObject.Find("EntradaArmadilha4");
                parede = GameObject.Find("Parede2");
            }
            if (gameObject.tag == "Arrow6")
            {
                SaidaArmadilha = GameObject.Find("Chão4");
                EntradaArmadilha = GameObject.Find("EntradaArmadilha6");
                parede = GameObject.Find("Parede3");
            }
            if (gameObject.tag == "Arrow8")
            {
                SaidaArmadilha = GameObject.Find("ChãoBoss");
                EntradaArmadilha = GameObject.Find("EntradaArmadilha8");
                parede = GameObject.Find("Parede4");
            }
            flag = false;
            fisica.isTrigger = true;
            EntradaArmadilha.transform.position = new Vector3(EntradaArmadilha.GetComponent<Bloqueio2>().xi, EntradaArmadilha.transform.position.y, 0.0f);
            EntradaArmadilha.GetComponent<BoxCollider2D>().isTrigger = true;
            SaidaArmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
            parede.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
