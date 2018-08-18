using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class FeedBack : MonoBehaviour
{

    public GameObject jogador;
    public Text PerguntaAtual;
    public List<String> Perguntas;
    public List<String> Certas;
    public List<String> Erradas;
    public GameObject Entrada;
    public Text Pergunta1;
    public Text Pergunta2;
    public Text Pergunta3;
    public Text Pergunta4;
    public Text Certa1;
    public Text Certa2;
    public Text Certa3;
    public Text Certa4;
    public Text Errada1;
    public Text Errada2;
    public Text Errada3;
    public Text Errada4;
    public bool muerte;
    // Use this for initialization
    void Start()
    {
        jogador = GameObject.Find("Player");
    }
    // Update is called once per frame
    void Update()
    {
        if (jogador.GetComponent<Walk>().morte)
        {
            Debug.Log("Testando se entrou na morte do feedback");
            Perguntas.Add(PerguntaAtual.text);
            if (Entrada.tag == "Entrada" || Entrada.tag == "Entrada3" || Entrada.tag == "Entrada5" || Entrada.tag == "Entrada7")
            {
                if(Entrada.GetComponent<Block>().rand == 0)
                {
                    Certas.Add(Entrada.GetComponent<Block>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Block>().texto2.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Block>().texto3.GetComponent<TextMesh>().text);
                }
                else if(Entrada.GetComponent<Block>().rand == 1)
                {
                    Certas.Add(Entrada.GetComponent<Block>().texto2.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Block>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Block>().texto3.GetComponent<TextMesh>().text);
                }
                else
                {
                    Certas.Add(Entrada.GetComponent<Block>().texto3.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Block>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Block>().texto2.GetComponent<TextMesh>().text);
                }
            }
            if (Entrada.tag == "Entrada2" || Entrada.tag == "Entrada4" || Entrada.tag == "Entrada6" || Entrada.tag == "Entrada8")
            {
                if (Entrada.GetComponent<Bloqueio2>().rand == 0)
                {
                    Certas.Add(Entrada.GetComponent<Bloqueio2>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Bloqueio2>().texto2.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Bloqueio2>().texto3.GetComponent<TextMesh>().text);
                }
                else if (Entrada.GetComponent<Bloqueio2>().rand == 1)
                {
                    Certas.Add(Entrada.GetComponent<Bloqueio2>().texto2.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Bloqueio2>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Bloqueio2>().texto3.GetComponent<TextMesh>().text);
                }
                else
                {
                    Certas.Add(Entrada.GetComponent<Bloqueio2>().texto3.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Bloqueio2>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<Bloqueio2>().texto2.GetComponent<TextMesh>().text);
                }
            }
            if (Entrada.tag == "EntradaBoss")
            {
                if (Entrada.GetComponent<BlockBoss>().rand == 0)
                {
                    Certas.Add(Entrada.GetComponent<BlockBoss>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<BlockBoss>().texto2.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<BlockBoss>().texto3.GetComponent<TextMesh>().text);
                }
                else if (Entrada.GetComponent<BlockBoss>().rand == 1)
                {
                    Certas.Add(Entrada.GetComponent<BlockBoss>().texto2.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<BlockBoss>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<BlockBoss>().texto3.GetComponent<TextMesh>().text);
                }
                else
                {
                    Certas.Add(Entrada.GetComponent<BlockBoss>().texto3.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<BlockBoss>().texto1.GetComponent<TextMesh>().text);
                    Erradas.Add(Entrada.GetComponent<BlockBoss>().texto2.GetComponent<TextMesh>().text);
                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TesteDoPlayer"))
        {
            if (jogador.GetComponent<Walk>().vida == -1)
            {
                Pergunta1.text = Perguntas[0];
                Pergunta2.text = Perguntas[1];
                Pergunta3.text = Perguntas[2];
                Pergunta4.text = Perguntas[3];
                Certa1.text = Certas[0];
                Certa2.text = Certas[1];
                Certa3.text = Certas[2];
                Certa4.text = Certas[3];
                Errada1.text = Erradas[0] + " e " + Erradas[1];
                Errada2.text = Erradas[2] + " e " + Erradas[3];
                Errada3.text = Erradas[4] + " e " + Erradas[5];
                Errada4.text = Erradas[6] + " e " + Erradas[7];
            }
            else if(jogador.GetComponent<Walk>().vida == 0)
            {
                Pergunta1.text = Perguntas[0];
                Pergunta2.text = Perguntas[1];
                Pergunta3.text = Perguntas[2];
                Certa1.text = Certas[0];
                Certa2.text = Certas[1];
                Certa3.text = Certas[2];
                Errada1.text = Erradas[0] + " e " + Erradas[1];
                Errada2.text = Erradas[2] + " e " + Erradas[3];
                Errada3.text = Erradas[4] + " e " + Erradas[5];
            }
            else if (jogador.GetComponent<Walk>().vida == 1)
            {
                Pergunta1.text = Perguntas[0];
                Pergunta2.text = Perguntas[1];
                Certa1.text = Certas[0];
                Certa2.text = Certas[1];
                Errada1.text = Erradas[0] + " e " + Erradas[1];
                Errada2.text = Erradas[2] + " e " + Erradas[3];
            }
            else if (jogador.GetComponent<Walk>().vida == 2)
            {
                Pergunta1.text = Perguntas[0];
                Certa1.text = Certas[0];
                Errada1.text = Erradas[0] + " e " + Erradas[1];
            }
        }
    }
}
