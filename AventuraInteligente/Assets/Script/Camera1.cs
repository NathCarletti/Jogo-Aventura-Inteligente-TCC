using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Camera1 : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    float x;
    public GameObject Chao;
    public GameObject jogador;
    public GameObject Madeira1F2;
    public GameObject Madeira2F2;
    public GameObject Madeira3F2;
    public GameObject Lateral1;
    public GameObject Lateral2;
    public BoxCollider2D saidaarmadilha2;
    public int flag;
    public List<Object> blocos;
    private Animator animator;
    public Transform spritePlayer;
    public int tempo;
    public GameObject GameOver;
    public GameObject pergunta;
    public GameObject Perguntas;
    public GameObject Pergunta1;
    public GameObject Pergunta2;
    public GameObject Pergunta3;
    public GameObject Pergunta4;
    public GameObject Certa1;
    public GameObject Certa2;
    public GameObject Certa3;
    public GameObject Certa4;
    public GameObject Errada1;
    public GameObject Errada2;
    public GameObject Errada3;
    public GameObject Errada4;
    public Text GameO;
    public GameObject Diploma;
    public GameObject Frase;
    public Text Fra;
    public GameObject shuri;
    // Use this for initialization
    void Start () {
        animator = spritePlayer.GetComponent<Animator>();
        tempo = 0;
        flag = 0;
        x = -27.4f;
        while(x<10.75f)
        {
            x += 0.87f;
            //GameObject chaos = Instantiate(Chao, new Vector3(x, Chao.transform.position.y, 0), Quaternion.identity);
            blocos.Add(Instantiate(Chao, new Vector3(x, Chao.transform.position.y, 0), Quaternion.identity));
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(jogador.GetComponent<Walk>().checkpoint == 0 && flag ==0)
        {
            //transform.position = new Vector3(-5.0f, 11.4f, offset.z);
            //verdadeiro
            Lateral1 = GameObject.Find("vert_trunk_small (7)");
            Lateral2 = GameObject.Find("vert_trunk_small (6)");
            Lateral1.SetActive(false);
            Lateral2.SetActive(false);
            Madeira1F2.SetActive(false);
            Madeira2F2.SetActive(false);
            Madeira3F2.SetActive(false);
            transform.position = new Vector3(-5.0f, -0.71f, offset.z);
            flag = 1;
        }
            
        else if(jogador.GetComponent<Walk>().checkpoint == 2 && flag == 1)
        {
            player.transform.position = new Vector3(player.transform.position.x,7.58f,0);
            transform.position = new Vector3(-5.0f, 13.4f, offset.z);
            saidaarmadilha2.isTrigger = false;
            Lateral1.SetActive(true);
            Lateral2.SetActive(true);
            Madeira1F2.SetActive(true);
            Madeira2F2.SetActive(true);
            Madeira3F2.SetActive(true);
            Lateral1 = GameObject.Find("vert_trunk_small (10)");
            Lateral2 = GameObject.Find("vert_trunk_small (11)");
            Lateral1.SetActive(false);
            Lateral2.SetActive(false);
            Destroy(GameObject.Find("vert_trunk_med1_F1"));
            Destroy(GameObject.Find("vert_trunk_med2_F1"));
            Destroy(GameObject.Find("vert_trunk_med3_F1"));
            Destroy(GameObject.Find("background"));
            Destroy(GameObject.Find("vert_trunk_small"));
            Destroy(GameObject.Find("vert_trunk_small (3)"));
            Destroy(GameObject.Find("rope"));
            Chao = GameObject.Find("Chão2");
            Chao.GetComponent<BoxCollider2D>().isTrigger = false;
            flag = 2;
            for (int i=0; i < 44; i++)
            {
                Destroy(blocos[i]);
            }
        }
        else if (jogador.GetComponent<Walk>().checkpoint == 4 && flag == 2)
        {
            transform.position = new Vector3(-5.0f, 27.6f, offset.z);
            Lateral1.SetActive(true);
            Lateral2.SetActive(true);
            Lateral1 = GameObject.Find("vert_trunk_small (20)");
            Lateral2 = GameObject.Find("vert_trunk_small (21)");
            Lateral1.SetActive(false);
            Lateral2.SetActive(false);
            Destroy(GameObject.Find("vert_trunk_med1_F2"));
            Destroy(GameObject.Find("vert_trunk_med2_F2"));
            Destroy(GameObject.Find("vert_trunk_med3_F2"));
            Destroy(GameObject.Find("background2"));
            Destroy(GameObject.Find("vert_trunk_small (6)"));
            Destroy(GameObject.Find("vert_trunk_small (7)"));
            Destroy(GameObject.Find("rope2"));
            Chao = GameObject.Find("Chão3");
            Chao.GetComponent<BoxCollider2D>().isTrigger = false;
            flag = 3;
        }
        else if (jogador.GetComponent<Walk>().checkpoint == 6 && flag == 3)
        {
            transform.position = new Vector3(-5.0f, 41.84f, offset.z);
            Lateral1.SetActive(true);
            Lateral2.SetActive(true);
            Lateral1 = GameObject.Find("vert_trunk_small (12)");
            Lateral2 = GameObject.Find("vert_trunk_small (13)");
            Lateral1.SetActive(false);
            Lateral2.SetActive(false);
            Destroy(GameObject.Find("vert_trunk_med1_F3"));
            Destroy(GameObject.Find("vert_trunk_med2_F3"));
            Destroy(GameObject.Find("vert_trunk_med3_F3"));
            Destroy(GameObject.Find("background3"));
            Destroy(GameObject.Find("vert_trunk_small (10)"));
            Destroy(GameObject.Find("vert_trunk_small (11)"));
            Destroy(GameObject.Find("rope3"));
            Chao = GameObject.Find("Chão4");
            Chao.GetComponent<BoxCollider2D>().isTrigger = false;
            flag = 4;
        }
        else if (jogador.GetComponent<Walk>().checkpoint == 8 && flag == 4)
        {
            transform.position = new Vector3(-5.0f, 56.0f, offset.z);
            Lateral1.SetActive(true);
            Lateral2.SetActive(true);
            Destroy(GameObject.Find("vert_trunk_med1_F4"));
            Destroy(GameObject.Find("vert_trunk_med2_F4"));
            Destroy(GameObject.Find("vert_trunk_med3_F4"));
            Destroy(GameObject.Find("background3"));
            Destroy(GameObject.Find("vert_trunk_small (20)"));
            Destroy(GameObject.Find("vert_trunk_small (21)"));
            Destroy(GameObject.Find("rope4"));
            flag = 5;
        }
        if (jogador.GetComponent<Walk>().vida == -1) 
        {
            transform.position = new Vector3(48.84f, 13.42f, offset.z);
            player.transform.position = new Vector3(49.0f,7.350845f,0f);
            player.GetComponent<Rigidbody2D>().isKinematic = true;
            animator.SetBool("Morte",true);
            GameOver.SetActive(true);
            Frase.SetActive(true);
            Perguntas.SetActive(true);
            Pergunta1.SetActive(true);
            Pergunta2.SetActive(true);
            Pergunta3.SetActive(true);
            Pergunta4.SetActive(true);
            Certa1.SetActive(true);
            Certa2.SetActive(true);
            Certa3.SetActive(true);
            Certa4.SetActive(true);
            Errada1.SetActive(true);
            Errada2.SetActive(true);
            Errada3.SetActive(true);
            Errada4.SetActive(true);
            pergunta.SetActive(false);
            tempo++;
            if (tempo == 300)
            {
                //Application.LoadLevel("Menu");
				SceneManager.LoadScene("Menu");
            }
        }
        if (jogador.GetComponent<Walk>().Colidiuboss)
        {
            transform.position = new Vector3(48.84f, 13.42f, offset.z);
            player.transform.position = new Vector3(49.0f, 7.350845f, 0f);
            player.GetComponent<Rigidbody2D>().isKinematic = true;
            animator.SetBool("Venceu", true);
            GameO.text = "Parabéns!!";
            GameOver.transform.position = new Vector3(849.0f, GameOver.transform.position.y, GameOver.transform.position.z);   
            GameOver.SetActive(true);
            Fra.text = "Agora você é um cavaleiro!";
            Frase.transform.position = new Vector3(881.0f, GameOver.transform.position.y-165, Frase.transform.position.z);
            Frase.SetActive(true);
            //shuri = GameObject.Find("shuriken (54)");
            //shuri.SetActive(false);
            Diploma.SetActive(true);
            Perguntas.SetActive(true);
            Pergunta1.SetActive(true);
            Pergunta2.SetActive(true);
            Pergunta3.SetActive(true);
            Pergunta4.SetActive(true);
            Certa1.SetActive(true);
            Certa2.SetActive(true);
            Certa3.SetActive(true);
            Certa4.SetActive(true);
            Errada1.SetActive(true);
            Errada2.SetActive(true);
            Errada3.SetActive(true);
            Errada4.SetActive(true);
            pergunta.SetActive(false);
            tempo++;
            if (tempo == 300)
            {
				SceneManager.LoadScene ("Menu");
                //Application.LoadLevel("Menu");
            }
        }
    }
}
