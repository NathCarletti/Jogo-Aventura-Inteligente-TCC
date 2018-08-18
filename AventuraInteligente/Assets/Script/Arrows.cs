using UnityEngine;
using System.Collections;

public class Arrows : MonoBehaviour {
    private bool flag;
    private Rigidbody2D rb;
    private BoxCollider2D fisica;
    public Transform flecha;
    public bool Entrada;
    public GameObject EntradaArmadilha;
    public BoxCollider2D EntradaArma;
    public GameObject SaidaArmadilha;
    public BoxCollider2D SaidaArma;
    public Collider2D Roof1;
    public Collider2D Roof2;
    public Collider2D Roof3;
    private BoxCollider2D ColliderRoof1;
    private int r,x;
    public bool dead;
    public GameObject personagem;
    public float xi1, yi1;

    
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        fisica = GetComponent<BoxCollider2D>();
        rb.isKinematic = true;
        flag = false;
        
    }
	
	// Update is called once per frame
	void Update () {
        Entrada = Block.AcionaTempo;
        //Entrada = EntradaArmadilha.GetComponent<Block>().AcionaTempo;
        dead = personagem.GetComponent<Walk>().morte;

        if (Entrada && !dead)
        {
            r = EntradaArmadilha.GetComponent<Block>().rand;
            
            if (Block.tempo < 0 && !flag)
            {
               if (r == 0)
               {
                    Roof1.isTrigger = false;
                    Roof2.isTrigger = true;
                    Roof3.isTrigger = true;
                }
               else if (r == 1)
               {
                    Roof1.isTrigger = true;
                    Roof2.isTrigger = false;
                    Roof3.isTrigger = true;
                }
               else
               {
                    Roof1.isTrigger = true;
                    Roof2.isTrigger = true;
                    Roof3.isTrigger = false;
                }
               rb.isKinematic = false;
               flag = true;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Chão" || other.gameObject.tag == "Roof")
        {
            rb.isKinematic = true;
            fisica.isTrigger = true;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+1.0f);
            SaidaArma.isTrigger= true;
            //olhar se a saidaarma esta sendo true ou false
        }
        if (other.gameObject.tag == "TesteDoPlayer")
        {
            Debug.Log("morte: " + dead);
            if(gameObject.tag == "Arrow1")
            {
                EntradaArmadilha = GameObject.Find("EntradaArmadilha");
            }
            if (gameObject.tag == "Arrow2")
            {
                EntradaArmadilha = GameObject.Find("EntradaArmadilha2");
            }
            if (gameObject.tag == "Arrow3")
            {
                EntradaArmadilha = GameObject.Find("EntradaArmadilha3");
            }
            if (gameObject.tag == "Arrow4")
            {
                EntradaArmadilha = GameObject.Find("EntradaArmadilha4");
            }
            if (gameObject.tag == "Arrow5")
            {
                EntradaArmadilha = GameObject.Find("EntradaArmadilha5");
            }
            if (gameObject.tag == "Arrow6")
            {
                EntradaArmadilha = GameObject.Find("EntradaArmadilha6");
            }
            if (gameObject.tag == "Arrow7")
            {
                EntradaArmadilha = GameObject.Find("EntradaArmadilha7");
            }
            if (gameObject.tag == "Arrow8")
            {
                EntradaArmadilha = GameObject.Find("EntradaArmadilha8");
            }
            flag = false;
            rb.isKinematic = true;
            fisica.isTrigger = true;
            EntradaArmadilha.transform.position = new Vector3(EntradaArmadilha.GetComponent<Block>().xi, EntradaArmadilha.transform.position.y, 0.0f);
            EntradaArma.isTrigger = true;
            SaidaArma.isTrigger = false;
        }
    }
}
