using UnityEngine;
//using System;
using System.Collections;
//using System.Data;
using Mono.Data.Sqlite;

public class AtivaPortal : MonoBehaviour {
	private string connectionString;
	//private Transform player;
	public Collider2D portal1;
	//public Transform plat11t;
	public Collider2D portal2;
	public Transform text;
	// public Transform text2;
	public GameObject texto1;
	public GameObject texto2;

	public GameObject portF;
	public GameObject testPF;

	//private GUIText texto;
	private Vector3 position;
	public bool portalT, portalO,pisou;
	int j, k, init, fim;
	string palavraC, palavraE;
	string[] teste;
	public string PE, PC;
    //private string[] palavraErrada = { "massã", "maçan", "masa", "caicha", "caxa", "cacha", "coelio", "coelhio", "coelo" };
    //private string[] palavraCerta = { "maçã","maçã", "maçã", "caixa", "caixa", "caixa", "coelho", "coelho", "coelho" };
    private string[] palavraErrada = { "CAICHA", "ARJILA", "ÂNCIA", "REPOUZO", "AVESTRUS", "ASSENSSÃO", "CONPROMISSO", "ASSAÍ", "ARROS", "CHÍCARA", "SELULAR", "CAZAMENTO", "AÇADO", "CASSADA", "FORSA" };
    private string[] palavraCerta = { "CAIXA", "ARGILA", "ÂNSIA", "REPOUSO", "AVESTRUZ", "ASCENSÃO", "COMPROMISSO", "AÇAÍ", "ARROZ", "XÍCARA", "CELULAR", "CASAMENTO", "ASSADO", "CAÇADA", "FORÇA" };

    private int i = 0;
	// Use this for initialization
	void Start () {
		//player = GameObject.FindGameObjectWithTag ("Player").transform;
		//texto = "oi";
		i = Random.Range (0, 14);   //pega numero de 0 a 8)
		//j = i % 3; //j recebe o resto, p saber onde eu to, ja q tem 3 palavras erradas p cada uma certa
		//  k = (i / 3) * 3; //pego a divisao (inteira!!! 7/3=2, 3*2=6 (onde começa)) ueh..n preciso disso
		//init = i - j; // ex 7- o resto da divisao q eh 1 = 6 (onde começo)
		//fim = i + (2 - j); //ex 7+(2-resto=1 = 1)=7+1=8 (ultimo valor)

		//Vector3 pos = new Vector3 (plat11t.position.x, plat11t.position.y, plat11t.z);
		// para seguir o player -> transform.LookAt(player.transform);

		connectionString = "URI=file:" + Application.dataPath + "/BDJogo.sqlite";
		//GetPalavras();
		teste = new string[2];
		portF = GameObject.Find ("FeedBack");
	}

	// Update is called once per frame
	void Update () {


	}



	void OnTriggerEnter2D(Collider2D other)

	{	//string [] teste1 = GetPalavraCerta();
		//	string PE, PC;
			PE = palavraErrada[i];
			PC = palavraCerta[i];
			int k = Random.Range (0, 100);
			if (other.gameObject.tag == "Player")
			{
				if (gameObject.tag == "APO1") {
					testPF = GameObject.Find ("ativaPortais");
					portF.GetComponent<Feedback> ().ap = testPF;
				} else if (gameObject.tag == "APO2") {
					testPF = GameObject.Find ("ativaPortais1");
					portF.GetComponent<Feedback> ().ap = testPF;
				}
				if (k > 50) {
					texto1.GetComponent<TextMesh>().text = PE;
					texto2.GetComponent<TextMesh>().text = PC;
					portalO = false;
					portalT = true;
					Debug.Log ("öi");
					//if(portal1.isTrigger)

				} else {
					portalO = true;
					portalT = false;
					texto2.GetComponent<TextMesh>().text = PE;
					texto1.GetComponent<TextMesh>().text = PC;
					Debug.Log("ola");
				}
			gameObject.SetActive (false);
			}



	}
	private string[] GetPalavraCerta()
	{
        return new string[] { };

		//using (IDbConnection dbConec = new SqliteConnection(connectionString))
		//{
		//	dbConec.Open();
		//	using (IDbCommand dbCom = dbConec.CreateCommand())
		//	{
		//		//string sqlQueryId = "SELECT Id FROM Palavras ORDER BY RANDOM() LIMIT 1";
		//		string sqlQuery = "SELECT Corretas, Incorretas FROM Palavras WHERE Id=(SELECT Id FROM Palavras ORDER BY RANDOM() LIMIT 1)";
		//		dbCom.CommandText = sqlQuery;

		//		using (IDataReader reader = dbCom.ExecuteReader())
		//		{
		//			reader.Read();
		//			teste[0] = reader.GetString(0);
		//			Debug.Log(reader.GetString(0));
		//			teste[1] = reader.GetString(1);
		//			Debug.Log(reader.GetString(1));
		//			//Debug.Log(reader.Read());
		//			/*while (reader.Read ()) {
		//				Debug.Log (reader.GetString (1));
		//			}*/

		//			dbConec.Close();
		//			return teste;
		//			//return palavraE;

		//		}

		//	}
		//}
	}
}
