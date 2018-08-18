using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private bool estaNoChao;
    public Transform chaoVerif;
    public Transform plSprite;
    private Animator anim;
	AudioSource sound;
	public AudioClip fase;
	public AudioClip chefe;

    private Rigidbody2D rb;
    public float velocidade;
    public float pular;

	public int cont=0;


    // Use this for initialization
    void Start()
    {
        anim = plSprite.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
		sound=GetComponent<AudioSource> ();
		//sound.clip = fase;
    }

    void Update() {
			Movimentacao ();

    }

	public void Movimentacao()
    {
        anim.SetFloat("movimento", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        transform.Translate(Vector2.right * velocidade * Mathf.Abs(Input.GetAxisRaw("Horizontal")) * Time.deltaTime);
        transform.localScale = new Vector3(Input.GetAxisRaw("Horizontal") >= 0f ? 1f : -1f, transform.localScale.y, transform.localScale.z);
          //if (Input.GetAxisRaw("Horizontal") > 0)
        //{
        //    transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        //    transform.eulerAngles = new Vector2(0, 0);
        //}
        //if (Input.GetAxisRaw("Horizontal") < 0)
        //{
        //    transform.Translate(Vector2.right
        //        * velocidade * Time.deltaTime);
        //    transform.eulerAngles = new Vector2(0, 180);
        //}

        estaNoChao = Physics2D.Linecast(transform.position, chaoVerif.position, 1 << LayerMask.NameToLayer("piso"));
        anim.SetBool("chao", estaNoChao);

        if (Input.GetButtonDown("Jump")&& estaNoChao)
        {
            rb.AddForce(transform.up * pular);
        }

       
    }

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("barBoss")) {
			sound.Stop ();
			sound.clip = chefe;
			sound.Play ();
		}		
	}

}


    
