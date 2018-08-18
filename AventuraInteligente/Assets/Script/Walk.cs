using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Walk : MonoBehaviour
{

    public float velocidade;
    new Rigidbody2D rigidbody;
    bool podePular = true;
    public int vida;
    public bool morte;
    public int numeroarma;
    public GameObject verde;
    public GameObject amarelo;
    public GameObject vermelho;
    public int checkpoint = 0;
    public float posicaox, posicaoy;
    AudioSource sound;
    public AudioClip Fase;
    public AudioClip Boss;
    bool flag;
    int TempoMov=0;
    public Transform spritePlayer;
    private Animator animator;
    //float testee;
    public GameObject Entrada;
    public List<Object> Flecha;
    public int Numero;
    public GameObject Arrow;
    public float x, y;
    public GameObject Eleva;
    bool flagCheck;
    public bool Colidiuboss;
    public bool ColidiuCorda;
    int tempocorda;
    bool AcionaTempoCorda;
    int ChecandoCheck;
    // Use this for initialization
    void Start()
    {
        sound = GetComponent<AudioSource>();
        Entrada = GameObject.Find("EntradaArmadilha");
        rigidbody = GetComponent<Rigidbody2D>();
        vida = 3;
        morte = false;
        numeroarma = 0;
        animator = spritePlayer.GetComponent<Animator>();
        flag = false;
        transform.Rotate(new Vector3(0, 180, 0));
        flagCheck = false;
        Colidiuboss = false;
        ColidiuCorda = false;
        tempocorda = 30;
        AcionaTempoCorda = false;
        ChecandoCheck = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
    }
    void Movimentacao()
    {
        TempoMov++;
        if (TempoMov > 180)
        {
            animator.SetFloat("MuitoTempo", 1);
        }
        animator.SetFloat("Movimento", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            
            //transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            //transform.eulerAngles = new Vector2(0, 0);
            TempoMov = 0;
            rigidbody.AddForce(new Vector3(10.0f, 0f, 0f));
            if (flag)
            {
                transform.Rotate(new Vector3(0, 180, 0));
                flag = false;
            }
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            TempoMov = 0;
            rigidbody.AddForce(new Vector3(-10.0f, 0f, 0f));
            if (!flag)
            {
                transform.Rotate(new Vector3(0, 180, 0));
                flag = true;
            }
        }
        
        animator.SetBool("Chao", podePular);
        if (Input.GetKey(KeyCode.Space))
        {
            if (podePular)
            {
                rigidbody.AddForce(new Vector3(0f, 200.0f, 0f));
                podePular = false;
            }
        }
        if (AcionaTempoCorda)
            if (tempocorda > 0)
                tempocorda--;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (ColidiuCorda)
            {
                AcionaTempoCorda = true;
                //rigidbody.constraints = RigidbodyConstraints2D.None;
                rigidbody.AddForce(new Vector3(0f, 15.0f, 0f));
                if (tempocorda <= 0)
                {
                    //rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                    AcionaTempoCorda = false;
                    tempocorda = 30;
                }
            }            
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Chão"))
        {
            podePular = true;
        }
        
        if (coll.gameObject.CompareTag("Arrow") || coll.gameObject.CompareTag("Arrow1") || coll.gameObject.CompareTag("Arrow3")) //|| coll.gameObject.CompareTag("Arrow5") || coll.gameObject.CompareTag("Arrow7"))
        {
            vida--;
            morte = true;
            ColidiuCorda = false;
            rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
			animator.SetBool("Corda", false);
            GetComponent<Rigidbody2D>().isKinematic = false;
            if (vida == 2)
            {
                verde.SetActive(false);
            }
            else if (vida == 1)
            {
                amarelo.SetActive(false);
            }
            else if (vida == 0)
            {
                vermelho.SetActive(false);
            }
            Debug.Log("vida: " + vida);
            if (checkpoint == 0)
            {
                transform.position = new Vector3(-20.06f, -6.51f, 0.0f);
            }
            else
            {
                transform.position = new Vector3(posicaox, posicaoy, 0.0f);
            }
            Numero = Entrada.GetComponent<Block>().NF;
            Flecha = new List<Object>();
            Flecha = Entrada.GetComponent<Block>().Flechas;
            for (int i = 0; i <= Numero; i++)
            {
                Destroy(Flecha[i]);
            }
            Arrow = Entrada.GetComponent<Block>().Flecha1Trap;
            x = Entrada.GetComponent<Block>().xa;
            y = Entrada.GetComponent<Block>().ya;
            Arrow.transform.position = new Vector3(x, y, 0.0f);
            Arrow.GetComponent<Rigidbody2D>().isKinematic = true;
        }
        if(coll.gameObject.CompareTag("Arrow2") || coll.gameObject.CompareTag("Arrow4") || coll.gameObject.CompareTag("Arrow6") || coll.gameObject.CompareTag("Arrow8"))
        {
            vida--;
            morte = true;
            ColidiuCorda = false;
            rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
            GetComponent<Rigidbody2D>().isKinematic = false;
            if (vida == 2)
            {
                verde.SetActive(false);
            }
            else if (vida == 1)
            {
                amarelo.SetActive(false);
            }
            else if (vida == 0)
            {
                vermelho.SetActive(false);
            }
            Debug.Log("vida na flecha de lado: " + vida);
            if (checkpoint == 0)
            {
                transform.position = new Vector3(-20.06f, -6.51f, 0.0f);
            }
            else
            {
                transform.position = new Vector3(posicaox, posicaoy, 0.0f);
            }
            Numero = Entrada.GetComponent<Bloqueio2>().NF;
            Flecha = new List<Object>();
            Flecha = Entrada.GetComponent<Bloqueio2>().Flechas;
            for (int i = 0; i <= Numero; i++)
            {
                Destroy(Flecha[i]);
            }
            Arrow = Entrada.GetComponent<Bloqueio2>().Flecha2Trap;
            x = Entrada.GetComponent<Bloqueio2>().xa;
            y = Entrada.GetComponent<Bloqueio2>().ya;
            Arrow.transform.position = new Vector3(x, y, 0.0f);
            Arrow.GetComponent<Rigidbody2D>().isKinematic = false;
			animator.SetBool("Corda", false);
        }

        if (coll.gameObject.CompareTag("ArrowBoss"))
        {
            vida--;
            morte = true;
            Debug.Log("Testando se morreu no boss e detectou no script walk");
            Entrada = GameObject.Find("EntradaArmadilhaBoss");
            Entrada.GetComponent<BlockBoss>().TempoFinal = false;
            Entrada.GetComponent<BlockBoss>().CountTempo = 480;
            GetComponent<Rigidbody2D>().isKinematic = false;
            if (vida == 2)
            {
                verde.SetActive(false);
            }
            else if (vida == 1)
            {
                amarelo.SetActive(false);
            }
            else if (vida == 0)
            {
                vermelho.SetActive(false);
            }
            Debug.Log("vida: " + vida);
            if (checkpoint == 0)
            {
                transform.position = new Vector3(-20.06f, -6.51f, 0.0f);
            }
            else
            {
                transform.position = new Vector3(posicaox, posicaoy, 0.0f);
            }
            Numero = Entrada.GetComponent<BlockBoss>().NF;
            Flecha = new List<Object>();
            Flecha = Entrada.GetComponent<BlockBoss>().Flechas;
            for (int i = 0; i <= Numero; i++)
            {
                Destroy(Flecha[i]);
            }
            Arrow = Entrada.GetComponent<BlockBoss>().Flecha1Trap;
            x = Entrada.GetComponent<BlockBoss>().xa;
            y = Entrada.GetComponent<BlockBoss>().ya;
            Arrow.transform.position = new Vector3(x, y, 0.0f);
            Arrow.GetComponent<Rigidbody2D>().isKinematic = true;
			animator.SetBool("Corda", false);
        }
        if (coll.gameObject.CompareTag("TheBigBosss"))
        {
            Colidiuboss = true;
        }
            
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CHK1"))
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            checkpoint = 1;
        }
        if (other.gameObject.CompareTag("CHK2"))
        {
            if(ChecandoCheck == 0)
            {
                rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
                GetComponent<Rigidbody2D>().isKinematic = false;
                transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 3.0f, 0.0f);
                checkpoint = 2;
                Entrada.GetComponent<Bloqueio2>().finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                Block.AcionaTempo = false;
                Block.tempo = 600;
                Debug.Log("checkpoint: " + checkpoint);
                animator.SetBool("Corda", false);
                ColidiuCorda = false;
                ChecandoCheck = 1;
            }
        }
        if (other.gameObject.CompareTag("CHK3"))
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            checkpoint = 3;
        }
        if (other.gameObject.CompareTag("CHK4"))
        {
            if(ChecandoCheck == 1)
            {
                rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
                GetComponent<Rigidbody2D>().isKinematic = false;
                transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 3.0f, 0.0f);
                Entrada.GetComponent<Bloqueio2>().finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                checkpoint = 4;
                animator.SetBool("Corda", false);
                ColidiuCorda = false;
                ChecandoCheck = 2;
            }

        }
        if (other.gameObject.CompareTag("CHK5"))
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            checkpoint = 5;
        }
        if (other.gameObject.CompareTag("CHK6"))
        {
            if(ChecandoCheck == 2)
            {
                rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
                GetComponent<Rigidbody2D>().isKinematic = false;
                transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 3.0f, 0.0f);
                Entrada.GetComponent<Bloqueio2>().finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                checkpoint = 6;
                animator.SetBool("Corda", false);
                ColidiuCorda = false;
                ChecandoCheck = 3;
            }

        }
        if (other.gameObject.CompareTag("CHK7"))
        {
            GetComponent<Rigidbody2D>().isKinematic = false;
            checkpoint = 7;
        }
        if (other.gameObject.CompareTag("CHK8") && !flagCheck)
        {
            if(ChecandoCheck == 3)
            {
                rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
                GetComponent<Rigidbody2D>().isKinematic = false;
                transform.position = new Vector3(other.transform.position.x, other.transform.position.y + 3.0f, 0.0f);
                Entrada.GetComponent<Bloqueio2>().finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                checkpoint = 8;
                animator.SetBool("Corda", false);
                sound.Stop();
                sound.clip = Boss;
                sound.Play();
                flagCheck = true;
                ColidiuCorda = false;
                ChecandoCheck = 4;
            }

        }
        if (other.gameObject.CompareTag("Entrada3"))
        {
            Entrada = GameObject.Find("EntradaArmadilha3");
        }
        if (other.gameObject.CompareTag("Entrada5"))
        {
            Entrada = GameObject.Find("EntradaArmadilha5");
        }
        if (other.gameObject.CompareTag("Entrada7"))
        {
            Entrada = GameObject.Find("EntradaArmadilha7");
        }
        if (other.gameObject.CompareTag("Entrada2"))
        {
            Entrada = GameObject.Find("EntradaArmadilha2");
        }
        if (other.gameObject.CompareTag("Entrada4"))
        {
            Entrada = GameObject.Find("EntradaArmadilha4");
        }
        if (other.gameObject.CompareTag("Entrada6"))
        {
            Entrada = GameObject.Find("EntradaArmadilha6");
        }
        if (other.gameObject.CompareTag("Entrada8"))
        {
            Entrada = GameObject.Find("EntradaArmadilha8");
        }
        if (other.gameObject.CompareTag("Corda"))
        {
            ColidiuCorda = true;
            animator.SetBool("Corda", true);
			rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        }
		if (other.gameObject.CompareTag("CordaBoss"))
		{
			ColidiuCorda = true;
			animator.SetBool("Corda", true);
			rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
		}
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Corda"))
        {
            Debug.Log("Saiu da colisão");
            ColidiuCorda = false;
            animator.SetBool("Corda", false);
            //rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
	/*void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Corda"))
		{
			animator.SetBool("Corda", true);
			rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
		}
	}*/
}
