using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class Bloqueio2 : MonoBehaviour {

    public static int tempo;
    public static bool AcionaTempo;
    public GameObject jogador;
    public GameObject parede;
    public GameObject finalarmadilha;
    public GameObject EntradaArma;
    public int NumeroDeFlecha;
    public GameObject Flecha2Trap;
    public float xi, xa, ya;
    float x, y;
    public int rand;
    private int correta;
    private int errada1;
    private int errada2;
    private int numero1;
    private int numero2;
    private string pergunta;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public Text perguntatexto;
    public GameObject Roof1;
    public GameObject Roof2;
    public GameObject Roof3;
    public List<Object> Flechas;
    public int NF;
    public GameObject ObjetoGameOver;
    bool flag;
    // Use this for initialization
    void Start()
    {
        flag = false;
        ObjetoGameOver = GameObject.Find("EntradaGameOver");
        tempo = 600;
        if (gameObject.tag == "Entrada2")
        {
            finalarmadilha = GameObject.Find("Chão2");
            EntradaArma = GameObject.Find("EntradaArmadilha2");
            parede = GameObject.Find("Parede");
            Roof1 = GameObject.Find("Roof1Arma2");
            Roof2 = GameObject.Find("Roof2Arma2");
            Roof3 = GameObject.Find("Roof3Arma2");
        }
        if (gameObject.tag == "Entrada4")
        {
            finalarmadilha = GameObject.Find("Chão3");
            EntradaArma = GameObject.Find("EntradaArmadilha4");
            parede = GameObject.Find("Parede2");
            Roof1 = GameObject.Find("Roof1A4");
            Roof2 = GameObject.Find("Roof2A4");
            Roof3 = GameObject.Find("Roof3A4");
        }
        if (gameObject.tag == "Entrada6")
        {
            finalarmadilha = GameObject.Find("Chão4");
            EntradaArma = GameObject.Find("EntradaArmadilha6");
            parede = GameObject.Find("Parede3");
            Roof1 = GameObject.Find("Roof1A6");
            Roof2 = GameObject.Find("Roof2A6");
            Roof3 = GameObject.Find("Roof3A6");
        }
        if (gameObject.tag == "Entrada8")
        {
            finalarmadilha = GameObject.Find("ChãoBoss");
            EntradaArma = GameObject.Find("EntradaArmadilha8");
            parede = GameObject.Find("Parede4");
            Roof1 = GameObject.Find("Roof1A8");
            Roof2 = GameObject.Find("Roof2A8");
            Roof3 = GameObject.Find("Roof3A8");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (AcionaTempo)
            if (tempo >= -60)
                tempo--;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0.0f);

        if (jogador.GetComponent<Walk>().morte == true)
        {
            tempo = 600;
            AcionaTempo = false;
           /* transform.position = new Vector3(xi, EntradaArma.transform.position.y, 0.0f);
            EntradaArma.GetComponent<BoxCollider2D>().isTrigger = true;
            finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;*/
            jogador.GetComponent<Walk>().morte = false;
            parede.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        if (jogador.GetComponent<Walk>().morte == false && tempo <= -60 && flag == false)
        {
           finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = true;
            flag = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "TesteDoPlayer")
        {
            Roof1.GetComponent<BoxCollider2D>().isTrigger = true;
            Roof2.GetComponent<BoxCollider2D>().isTrigger = true;
            Roof3.GetComponent<BoxCollider2D>().isTrigger = true;
            tempo = 600;
            flag = false;
            Flechas = new List<Object>();
            if (gameObject.tag == "Entrada2")
            {
                finalarmadilha = GameObject.Find("Chão2");
                finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                NumeroDeFlecha = 0;
                Flecha2Trap = GameObject.Find("Arrow2Trap");
                Flecha2Trap.GetComponent<BoxCollider2D>().isTrigger = false;
                xa = Flecha2Trap.transform.position.x;
                ya = Flecha2Trap.transform.position.y;
                Flecha2Trap.transform.position = new Vector3(10.01f,-6.87f, 0f);
                xi = transform.position.x;
                transform.position = new Vector3(3.88f, transform.position.y, 0.0f);
                EntradaArma = GameObject.Find("EntradaArmadilha2");
                ObjetoGameOver.GetComponent<FeedBack>().Entrada = EntradaArma;
                EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
                y = Flecha2Trap.transform.position.y;
                NF = 16;
                Flechas = new List<Object>();
                while (NumeroDeFlecha <= 16)
                {
                    y += 0.66f;
                    x = Random.Range(-1.0f, 1.0f);
                    Flechas.Add(Instantiate(Flecha2Trap, new Vector3(Flecha2Trap.transform.position.x + x, y, 0), Quaternion.Euler(new Vector3(0, 0, -90))));
                    NumeroDeFlecha++;
                }
                Flecha2Trap.transform.position = new Vector3(xa, ya, 0f);
                parede = GameObject.Find("Parede");
                parede.GetComponent<BoxCollider2D>().isTrigger = false;
                texto1 = GameObject.Find("Texto1Arma2");
                texto2 = GameObject.Find("Texto2Arma2");
                texto3 = GameObject.Find("Texto3Arma2");
            }
            if (gameObject.tag == "Entrada4")
            {
                finalarmadilha = GameObject.Find("Chão3");
                finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                NumeroDeFlecha = 0;
                Flecha2Trap = GameObject.Find("Arrow2Trap4");
                Flecha2Trap.GetComponent<BoxCollider2D>().isTrigger = false;
                xa = Flecha2Trap.transform.position.x;
                ya = Flecha2Trap.transform.position.y;
                Flecha2Trap.transform.position = new Vector3(-20.25f, 7.36f, 0f);
                xi = transform.position.x;
                transform.position = new Vector3(-14.02f, transform.position.y, 0.0f);
                EntradaArma = GameObject.Find("EntradaArmadilha4");
                ObjetoGameOver.GetComponent<FeedBack>().Entrada = EntradaArma;
                EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
                y = Flecha2Trap.transform.position.y;
                NF = 16;
                Flechas = new List<Object>();
                while (NumeroDeFlecha <= 16)
                {
                    y += 0.66f;
                    x = Random.Range(-0.6f, 0.6f);
                    Flechas.Add(Instantiate(Flecha2Trap, new Vector3(Flecha2Trap.transform.position.x + x, y, 0), Quaternion.Euler(new Vector3(0, 180, -90))));
                    NumeroDeFlecha++;
                }
                Flecha2Trap.transform.position = new Vector3(xa, ya, 0f);
                parede = GameObject.Find("Parede2");
                parede.GetComponent<BoxCollider2D>().isTrigger = false;
                texto1 = GameObject.Find("Texto1Arma4");
                texto2 = GameObject.Find("Texto2Arma4");
                texto3 = GameObject.Find("Texto3Arma4");
            }
            if (gameObject.tag == "Entrada6")
            {
                finalarmadilha = GameObject.Find("Chão4");
                finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                NumeroDeFlecha = 0;
                Flecha2Trap = GameObject.Find("Arrow2Trap6");
                Flecha2Trap.GetComponent<BoxCollider2D>().isTrigger = false;
                xa = Flecha2Trap.transform.position.x;
                ya = Flecha2Trap.transform.position.y;
                Flecha2Trap.transform.position = new Vector3(10.01f, 21.5f, 0f);
                xi = transform.position.x;
                transform.position = new Vector3(3.88f, transform.position.y, 0.0f);
                EntradaArma = GameObject.Find("EntradaArmadilha6");
                ObjetoGameOver.GetComponent<FeedBack>().Entrada = EntradaArma;
                EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
                y = Flecha2Trap.transform.position.y;
                NF = 16;
                Debug.Log("Testando se entrou na entrada6");
                Flechas = new List<Object>();
                while (NumeroDeFlecha <= 16)
                {
                    y += 0.66f;
                    x = Random.Range(-1.0f, 1.0f);
                    Flechas.Add(Instantiate(Flecha2Trap, new Vector3(Flecha2Trap.transform.position.x + x, y, 0), Quaternion.Euler(new Vector3(0, 0, -90))));
                    NumeroDeFlecha++;
                }
                Flecha2Trap.transform.position = new Vector3(xa, ya, 0f);
                parede = GameObject.Find("Parede3");
                parede.GetComponent<BoxCollider2D>().isTrigger = false;
                texto1 = GameObject.Find("Texto1A6");
                texto2 = GameObject.Find("Texto2A6");
                texto3 = GameObject.Find("Texto3A6");
            }
            if (gameObject.tag == "Entrada8")
            {
                finalarmadilha = GameObject.Find("ChãoBoss");
                finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
                NumeroDeFlecha = 0;
                Flecha2Trap = GameObject.Find("Arrow2Trap8");
                Flecha2Trap.GetComponent<BoxCollider2D>().isTrigger = false;
                xa = Flecha2Trap.transform.position.x;
                ya = Flecha2Trap.transform.position.y;
                Flecha2Trap.transform.position = new Vector3(-20.25f, 35.9f, 0f);
                xi = transform.position.x;
                transform.position = new Vector3(-14.02f, transform.position.y, 0.0f);
                EntradaArma = GameObject.Find("EntradaArmadilha8");
                ObjetoGameOver.GetComponent<FeedBack>().Entrada = EntradaArma;
                EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
                y = Flecha2Trap.transform.position.y;
                NF = 16;
                Flechas = new List<Object>();
                while (NumeroDeFlecha <= 16)
                {
                    y += 0.66f;
                    x = Random.Range(-0.6f, 0.6f);
                    Flechas.Add(Instantiate(Flecha2Trap, new Vector3(Flecha2Trap.transform.position.x + x, y, 0), Quaternion.Euler(new Vector3(0, 180, -90))));
                    NumeroDeFlecha++;
                }
                Flecha2Trap.transform.position = new Vector3(xa, ya, 0f);
                parede = GameObject.Find("Parede4");
                parede.GetComponent<BoxCollider2D>().isTrigger = false;
                texto1 = GameObject.Find("Texto1A8");
                texto2 = GameObject.Find("Texto2A8");
                texto3 = GameObject.Find("Texto3A8");
            }
            rand = Random.Range(0, 3);
            Debug.Log("do segundo bloqueio r= " + rand);
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
                Roof1.GetComponent<BoxCollider2D>().isTrigger = false;
            }
            else if (rand == 1)
            {
                texto2.GetComponent<TextMesh>().text = "" + correta;
                texto1.GetComponent<TextMesh>().text = "" + errada1;
                texto3.GetComponent<TextMesh>().text = "" + errada2;
                Roof2.GetComponent<BoxCollider2D>().isTrigger = false;
            }
            else
            {
                texto3.GetComponent<TextMesh>().text = "" + correta;
                texto1.GetComponent<TextMesh>().text = "" + errada1;
                texto2.GetComponent<TextMesh>().text = "" + errada2;
                Roof3.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
    }
}
