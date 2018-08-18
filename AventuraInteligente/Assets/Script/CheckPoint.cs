using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour
{

    public GameObject jogador;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "TesteDoPlayer")
        {
            jogador.GetComponent<Walk>().posicaox = transform.position.x;
            jogador.GetComponent<Walk>().posicaoy = transform.position.y;
        }
    }
}