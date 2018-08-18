using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Block : MonoBehaviour
{
    public static bool AcionaTempo;
    public int rand;
    public static int tempo;
    public Text perguntatexto;
    private int correta;
    private int errada1;
    private int errada2;
    private int numero1;
    private int numero2;
    private string pergunta;
    public GameObject jogador;
    public GameObject finalarmadilha;
    public GameObject EntradaArma;
    public bool flag;
    public GameObject Roof1;
    public GameObject Roof2;
    public GameObject Roof3;
    int NumeroDeFlecha;
    public int NF;
    float x, y;
    public GameObject Flecha1Trap;
    public float xi, xa, ya;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public List<Object> Flechas;
    public GameObject ObjetoGameOver;
    public string nome;
    public string[] nome2;
    // Use this for initialization
    void Start()
    {
        tempo = 600;
        flag = false;
        NF = 0;
        ObjetoGameOver = GameObject.Find("EntradaGameOver");
    }

    // Update is called once per frame
    void Update()
    {
        if (AcionaTempo)
            if (tempo >= 0)
                tempo--;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0.0f);

        if (jogador.GetComponent<Walk>().morte == true)
        {
            if(gameObject.tag != "Entrada7")
            {
                Debug.Log("Entrou nessa morteeeeeeeeeeeeeeeeeee");
                tempo = 600;
                AcionaTempo = false;
                Debug.Log("Aciona Tempo: " + AcionaTempo);
                jogador.GetComponent<Walk>().morte = false;
                perguntatexto.text = " ";
            }
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "TesteDoPlayer")
        {
            tempo = 600;
            Flechas = new List<Object>();
            if (gameObject.tag == "Entrada")
            {
                finalarmadilha = GameObject.Find("SaidaArmadilha");
                finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                NumeroDeFlecha = 0;
                Flecha1Trap = GameObject.Find("Arrow1Trap");
                Flecha1Trap.GetComponent<BoxCollider2D>().isTrigger = false;
                xa = Flecha1Trap.transform.position.x;
                ya = Flecha1Trap.transform.position.y;
                Flecha1Trap.transform.position = new Vector3(-15.76f, 4.35f, 0f);
                xi = transform.position.x;
                transform.position = new Vector3(-18.5f, transform.position.y, 0.0f);
                EntradaArma = GameObject.Find("EntradaArmadilha");
                ObjetoGameOver.GetComponent<FeedBack>().Entrada = EntradaArma;
                EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
                x = -18.11f;
                NF = 26;
                Flechas = new List<Object>();
                while (NumeroDeFlecha <= 26)
                {
                    x += 0.66f;
                    y = Random.Range(-1.0f, 1.0f);
                    Flechas.Add(Instantiate(Flecha1Trap, new Vector3(x, Flecha1Trap.transform.position.y + y, 0), Quaternion.identity));
                    NumeroDeFlecha++;
                }
                Flecha1Trap.transform.position = new Vector3(xa, ya, 0f);
                texto1 = GameObject.Find("Texto1");
                texto2 = GameObject.Find("Texto2");
                texto3 = GameObject.Find("Texto3");
            }
            else if (gameObject.tag == "Entrada3")
            {
                Debug.Log("Teste se entrou aqui na armadilha 3");
                finalarmadilha = GameObject.Find("SaidaArmadilha3");
                finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                NumeroDeFlecha = 0;
                Flecha1Trap = GameObject.Find("Arrow1Trap3");
                Flecha1Trap.GetComponent<BoxCollider2D>().isTrigger = false;
                xa = Flecha1Trap.transform.position.x;
                ya = Flecha1Trap.transform.position.y;
                Flecha1Trap.transform.position = new Vector3(-13.42f, 18.56f, 0f);
                xi = transform.position.x;
                transform.position = new Vector3(2.0f, transform.position.y, 0.0f);
                EntradaArma = GameObject.Find("EntradaArmadilha3");
                ObjetoGameOver.GetComponent<FeedBack>().Entrada = EntradaArma;
                EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
                x = -13.14f;
                NF = 21;
                Flechas = new List<Object>();
                while (NumeroDeFlecha <= 21)
                {
                    x += 0.66f;
                    y = Random.Range(-1.0f, 1.0f);
                    Flechas.Add(Instantiate(Flecha1Trap, new Vector3(x, Flecha1Trap.transform.position.y + y, 0), Quaternion.identity));
                    NumeroDeFlecha++;
                }
                Flecha1Trap.transform.position = new Vector3(xa, ya, 0f);
                texto1 = GameObject.Find("Texto1Arma3");
                texto2 = GameObject.Find("Texto2Arma3");
                texto3 = GameObject.Find("Texto3Arma3");
            }
            else if(gameObject.tag == "Entrada5")
            {
                Debug.Log("Teste se entrou aqui na armadilha 5");
                finalarmadilha = GameObject.Find("SaidaArmadilha5");
                finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                NumeroDeFlecha = 0;
                Flecha1Trap = GameObject.Find("Arrow1Trap5");
                Flecha1Trap.GetComponent<BoxCollider2D>().isTrigger = false;
                xa = Flecha1Trap.transform.position.x;
                ya = Flecha1Trap.transform.position.y;
                Flecha1Trap.transform.position = new Vector3(-15.93f, 32.8f, 0f);
                xi = transform.position.x;
                transform.position = new Vector3(-16.0f, transform.position.y, 0.0f);
                EntradaArma = GameObject.Find("EntradaArmadilha5");
                ObjetoGameOver.GetComponent<FeedBack>().Entrada = EntradaArma;
                EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
                x = -15.93f;
                NF = 26;
                Flechas = new List<Object>();
                while (NumeroDeFlecha <= 26)
                {
                    x += 0.66f;
                    y = Random.Range(-1.0f, 1.0f);
                    Flechas.Add(Instantiate(Flecha1Trap, new Vector3(x, Flecha1Trap.transform.position.y + y, 0), Quaternion.identity));
                    NumeroDeFlecha++;
                }
                Flecha1Trap.transform.position = new Vector3(xa, ya, 0f);
                texto1 = GameObject.Find("Texto1A5");
                texto2 = GameObject.Find("Texto2A5");
                texto3 = GameObject.Find("Texto3A5");
            }
            else if (gameObject.tag == "Entrada7")
            {
                Debug.Log("Teste se entrou aqui na armadilha 7");
                finalarmadilha = GameObject.Find("SaidaArmadilha7");
                finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                NumeroDeFlecha = 0;
                Flecha1Trap = GameObject.Find("Arrow1Trap7"); 
                Flecha1Trap.GetComponent<BoxCollider2D>().isTrigger = false;
                xa = Flecha1Trap.transform.position.x;
                ya = Flecha1Trap.transform.position.y;
                Flecha1Trap.transform.position = new Vector3(-13.42f, 45.73f, 0f);
                xi = transform.position.x;
                transform.position = new Vector3(2.0f, transform.position.y, 0.0f);
                EntradaArma = GameObject.Find("EntradaArmadilha7");
                ObjetoGameOver.GetComponent<FeedBack>().Entrada = EntradaArma;
                EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
                x = -13.42f;
                NF = 21;
                Flechas = new List<Object>();
                while (NumeroDeFlecha <= 21)
                {
                    x += 0.66f;
                    y = Random.Range(-1.0f, 1.0f);
                    Flechas.Add(Instantiate(Flecha1Trap, new Vector3(x, Flecha1Trap.transform.position.y + y, 0), Quaternion.identity));
                    NumeroDeFlecha++;
                }
                Flecha1Trap.transform.position = new Vector3(xa, ya, 0f);
                texto1 = GameObject.Find("Texto1A7");
                texto2 = GameObject.Find("Texto2A7");
                texto3 = GameObject.Find("Texto3A7");
            }
            rand = Random.Range(0, 3);
            Debug.Log("r=" + rand);
            numero1 = Random.Range(0, 10);
            numero2 = Random.Range(0, 10);
            correta = numero1 * numero2;
            errada1 = errada2 = 0;
            do
            {
                errada1 = Random.Range(0, 10) * Random.Range(0, 10);
            } while (errada1 == correta);
            do
            {
                errada2 = Random.Range(numero1, 10) * Random.Range(numero2, 10);
            } while (errada2 == correta || errada2 == errada1);
            pergunta = numero1 + "x" + numero2;
            perguntatexto.text = pergunta;
            AcionaTempo = true;
            if (rand == 0)
            {
                texto1.GetComponent<TextMesh>().text = "" + correta;
                texto2.GetComponent<TextMesh>().text = "" + errada1;
                texto3.GetComponent<TextMesh>().text = "" + errada2;
            }
            else if (rand == 1)
            {
                texto2.GetComponent<TextMesh>().text = "" + correta;
                texto1.GetComponent<TextMesh>().text = "" + errada1;
                texto3.GetComponent<TextMesh>().text = "" + errada2;
            }
            else
            {
                texto3.GetComponent<TextMesh>().text = "" + correta;
                texto1.GetComponent<TextMesh>().text = "" + errada1;
                texto2.GetComponent<TextMesh>().text = "" + errada2;
            }
        }
    }
}