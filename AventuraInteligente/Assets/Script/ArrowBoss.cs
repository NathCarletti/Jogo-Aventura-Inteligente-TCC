using UnityEngine;
using System.Collections;

public class ArrowBoss : MonoBehaviour {
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
    private int r, x;
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
        Entrada = BlockBoss.AcionaTempo;
        dead = personagem.GetComponent<Walk>().morte;

        if (Entrada && !dead)
        {
            r = EntradaArmadilha.GetComponent<BlockBoss>().rand;

            if (BlockBoss.tempo < 0 && !flag)
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
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1.0f);
            SaidaArma.isTrigger = true;
        }
        if (other.gameObject.tag == "TesteDoPlayer")
        {
            Debug.Log("morte: " + dead);
            EntradaArmadilha = GameObject.Find("EntradaArmadilhaBoss");
            flag = false;
            rb.isKinematic = true;
            fisica.isTrigger = true;
            EntradaArmadilha.transform.position = new Vector3(EntradaArmadilha.GetComponent<BlockBoss>().xi, EntradaArmadilha.transform.position.y, 0.0f);
            EntradaArmadilha.GetComponent<BoxCollider2D>().isTrigger = true;
            EntradaArma.isTrigger = true;
            SaidaArma.isTrigger = false;
        }
    }
}
