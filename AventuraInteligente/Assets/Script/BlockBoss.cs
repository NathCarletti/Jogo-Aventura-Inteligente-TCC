using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class BlockBoss : MonoBehaviour
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
    public int NumeroDeFlecha;
    float x, y;
    public GameObject Flecha1Trap;
    public float xi, xa, ya;
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public int Quantidade;
    public List<Object> Flechas;
    public int NF;
    public bool TempoFinal;
    public int CountTempo;
    public GameObject ObjetoGameOverr;
    public int NumArma = 0;
    public GameObject CordaBosss;
    int atraso;
    bool AcionaAtraso;
    int Verifica;
    // Use this for initialization
    void Start()
    {
        tempo = 180;
        flag = false;
        TempoFinal = false;
        ObjetoGameOverr = GameObject.Find("EntradaGameOver");
        CountTempo = 360;
        AcionaAtraso = false;
        atraso = 30;
        Verifica = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (AcionaTempo)
            if (tempo >= 0)
                tempo--;
        if (TempoFinal)
            if (CountTempo >= 0)
            {
                CountTempo--;
                Verifica++;
            }
        if(CountTempo < 0 && NumArma < 4)
        {
            NumArma++;
            TempoFinal = false;
            AcionaTempo = false;
            CountTempo = 360;
			tempo = 180;
            for (int i = 0; i <= NF; i++)
            {
                Destroy(Flechas[i]);
            }
            Flechas = new List<Object>();
            finalarmadilha = GameObject.Find("Trava");
            finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
            NumeroDeFlecha = 0;
            Flecha1Trap = GameObject.Find("ArrowBoss");
            Flecha1Trap.GetComponent<BoxCollider2D>().isTrigger = false;
            xa = Flecha1Trap.transform.position.x;
            ya = Flecha1Trap.transform.position.y;
            Flecha1Trap.transform.position = new Vector3(-14.61f, 60.22f, 0f);
            xi = transform.position.x;
            transform.position = new Vector3(-15.13f, transform.position.y, 0.0f);
            EntradaArma = GameObject.Find("EntradaArmadilhaBoss");
            ObjetoGameOverr.GetComponent<FeedBack>().Entrada = EntradaArma;
            EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
            x = -14.61f;
            NF = 29;
            texto1 = GameObject.Find("Texto1Boss");
            texto2 = GameObject.Find("Texto2Boss");
            texto3 = GameObject.Find("Texto3Boss");

            while (NumeroDeFlecha <= 29)
            {
                x += 0.66f;
                y = Random.Range(-1.0f, 1.0f);
                Flechas.Add(Instantiate(Flecha1Trap, new Vector3(x, Flecha1Trap.transform.position.y + y, 0), Quaternion.identity));
                NumeroDeFlecha++;
            }
            Flecha1Trap.transform.position = new Vector3(xa, ya, 0f);

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
            TempoFinal = true;
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
        if (NumArma == 4 && Verifica > 1800)
        {
            CordaBosss.transform.position = new Vector3(CordaBosss.transform.position.x, 56.8f, CordaBosss.transform.position.z);
        }
        /*if (NumArma == 4)
        {
            AcionaAtraso = true;
        }
        if (AcionaAtraso)
            if(atraso > 0)
                atraso--;
        if(atraso <= 0)
        {
            if(CordaBosss.transform.position.y > 57.0f)
            {
                CordaBosss.GetComponent<Rigidbody2D>().MovePosition(transform.position + Vector3.down * 1.0f);
            }
            AcionaAtraso = false;
            atraso = 30;
        }*/
        transform.position = new Vector3(transform.position.x, transform.position.y, 0.0f);

        if (jogador.GetComponent<Walk>().morte == true)
        {
            Debug.Log("Testando se entrou na morte no boss");
			tempo = 180;
            AcionaTempo = false;
            jogador.GetComponent<Walk>().morte = false;
            TempoFinal = false;
            CountTempo = 360;
            NumArma = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "TesteDoPlayer")
        {
            TempoFinal = false;
            AcionaTempo = false;
            CountTempo = 360;
            tempo = 180;
            Flechas = new List<Object>();
            finalarmadilha = GameObject.Find("Trava");
            finalarmadilha.GetComponent<BoxCollider2D>().isTrigger = false;
            NumeroDeFlecha = 0;
            Flecha1Trap = GameObject.Find("ArrowBoss");
            Flecha1Trap.GetComponent<BoxCollider2D>().isTrigger = false;
            xa = Flecha1Trap.transform.position.x;
            ya = Flecha1Trap.transform.position.y;
            Flecha1Trap.transform.position = new Vector3(-14.61f, 60.22f, 0f);
            xi = transform.position.x;
            transform.position = new Vector3(-15.13f, transform.position.y, 0.0f);
            EntradaArma = GameObject.Find("EntradaArmadilhaBoss");
            ObjetoGameOverr.GetComponent<FeedBack>().Entrada = EntradaArma;
            EntradaArma.GetComponent<BoxCollider2D>().isTrigger = false;
            x = -14.61f;
            NF = 29;
            texto1 = GameObject.Find("Texto1Boss");
            texto2 = GameObject.Find("Texto2Boss");
            texto3 = GameObject.Find("Texto3Boss");

            while (NumeroDeFlecha <= 29)
            {
                x += 0.66f;
                y = Random.Range(-1.0f, 1.0f);
                Flechas.Add(Instantiate(Flecha1Trap, new Vector3(x, Flecha1Trap.transform.position.y + y, 0), Quaternion.identity));
                NumeroDeFlecha++;
            }
            Flecha1Trap.transform.position = new Vector3(xa, ya, 0f);

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
            TempoFinal = true;
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