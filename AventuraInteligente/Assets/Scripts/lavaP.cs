using UnityEngine;
using System.Collections;

public class lavaP : MonoBehaviour {
    private Transform player;
    public GameObject cor1;
    public GameObject cor2;
    public GameObject cor3;
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
	public GameObject objeto4;
	public GameObject obejto5;
	public GameObject objeto6;
    private checkPoints cp1;
    private checkPoints2 cp2;
    private checkPoints3 cp3;
	private checkPoint4 cp4;
	private BolaDeFogo bf;
	private AtivaChefe ativC;
	private Animator anim;
	public Transform playerS;
	//public Plataforma plat;
	public bool FB=false;



	//public GameObject jogador;
	//private Player p;

	public int contador, tempo;

    // Use this for initialization
    void Start () {
		cp1 = objeto1.GetComponent<checkPoints>();
		cp2 = objeto2.GetComponent<checkPoints2>();
		cp3 = objeto3.GetComponent<checkPoints3>();
		cp4 = objeto4.GetComponent<checkPoint4>();
		bf = obejto5.GetComponent<BolaDeFogo> ();
		ativC = objeto6.GetComponent<AtivaChefe> ();

		contador = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
		anim = playerS.GetComponent<Animator> ();
    }


		

    void OnCollisionEnter2D(Collision2D other)
	{	
        if (other.gameObject.tag == "lava")
        {
			//cont=cont+1;
			contador = contador+1;
			Debug.Log (contador);

			if (contador == 1)
            {
                cor1.SetActive(false);
				cor2.SetActive (true);
				cor3.SetActive (true);
				//plat.GetComponent<Plataforma> ().gameObject.SetActive (true);
				Debug.Log (contador);
				if (cp4.conti==true) //== 1 && cp2.conti == 0 && cp3.conti == 0)
                {
                    player.position = new Vector3(-6, 4, 0);
                    Debug.Log("ch4");
					bf.cont = 0;
					ativC.GetComponent<BoxCollider2D> ().isTrigger = true;
					ativC.conti = false;

				}	else if (cp3.conti == true)
				{
					player.position = new Vector3(4, 0.8f, 0);
					Debug.Log("cp3");
				}
				else if (cp2.conti == true)
                {
                    player.position = new Vector3(-3, -4, 0);
                    Debug.Log("cp2");
                }
			
				else if (cp1.conti == true)
                {
                    player.position = new Vector3(3, -8, 0);
                    Debug.Log("cp1");
                }
                else
                {
                    player.position = new Vector3(-4, -8, 0);
                    Debug.Log("sem cp");
                }
            }
			else if (contador == 2)
            {
				Debug.Log("cont2");
				cor1.SetActive(false);
				cor2.SetActive (false);
				cor3.SetActive (true);
				//plat.GetComponent<Plataforma> ().gameObject.SetActive (true);
				if (cp4.conti==true)
				{
					player.position = new Vector3(-6, 4, 0);
					Debug.Log("ch4");
					bf.cont = 0;
					ativC.GetComponent<BoxCollider2D> ().isTrigger = true;
					ativC.conti = false;
				}
				else if (cp3.conti == true)
				{
					player.position = new Vector3(4.0f, 0.8f, 0);
					Debug.Log("cp3");
				}
				else if (cp2.conti == true)
				{
					player.position = new Vector3(-3, -4, 0);
					Debug.Log("cp2");
				}
				else if (cp1.conti == true)
				{
					player.position = new Vector3(3, -8, 0);
					Debug.Log("cp1");
				}
				else
				{
					player.position = new Vector3(-4, -8, 0);
					Debug.Log("sem cp");
				}
            }
			else if (contador == 3)
            {
				Debug.Log("cont3");
				cor1.SetActive(false);
				cor2.SetActive (false);
				cor3.SetActive (false);
				//plat.GetComponent<Plataforma> ().gameObject.SetActive (true);
				if (cp4.conti==true) //== 1 && cp2.conti == 0 && cp3.conti == 0)
				{
					player.position = new Vector3(-6, 4, 0);
					Debug.Log("ch4");
					bf.cont = 0;
					ativC.GetComponent<BoxCollider2D> ().isTrigger = true;
					ativC.conti = false;
				}
				else if (cp3.conti == true)
				{
					player.position = new Vector3(4, 0.8f, 0);
					Debug.Log("cp3");
				}
				else if (cp2.conti == true)
				{
					player.position = new Vector3(-3, -4, 0);
					Debug.Log("cp2");
				}
				else if (cp1.conti == true)
				{
					player.position = new Vector3(3, -8, 0);
					Debug.Log("cp1");
				}
				else
				{
					player.position = new Vector3(-4, -8, 0);
					Debug.Log("sem cp");
				}
            }
            else
            {
				FB=true;
				contador = 0;
				Debug.Log ("oi");
                player.position = new Vector3(54f, -1.21f, 0f);
				anim.SetBool("morto",true);
                cor1.SetActive(true);
                cor2.SetActive(true);
                cor3.SetActive(true);
				cp1.conti = false;
				cp2.conti = false;
				cp3.conti = false;
				/*tempo++;
				Debug.Log (tempo);
				if (tempo >= 300){
					player.position = new Vector3(-5f, 4f, 0f);
					Debug.Log ("morri");
					//Application.LoadLevel ("menu");
				}*/
            }

        }
    }
}
