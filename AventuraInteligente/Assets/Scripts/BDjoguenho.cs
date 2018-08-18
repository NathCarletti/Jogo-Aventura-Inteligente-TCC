using UnityEngine;
using System.Collections;
//using System;
//using System.Data;
using Mono.Data.Sqlite;
public class BDjoguenho : MonoBehaviour {
	private string connectionString;
	// Use this for initialization
	void Start () {
		connectionString = "URI=file:" + Application.dataPath + "/BDJogo.sqlite";
		GetPalavras ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void GetPalavras(){

		//using (IDbConnection dbConec = new SqliteConnection (connectionString)) {
		//	dbConec.Open ();
		//	using (IDbCommand dbCom = dbConec.CreateCommand()) {
		//		string sqlQuery = "SELECT Corretas, Incorretas FROM Palavras";
  //              dbCom.CommandText = sqlQuery;


		//		using (IDataReader reader = dbCom.ExecuteReader ()) {
		//			reader.Read ();
		//			Debug.Log (reader.GetString (1));
  //                  Debug.Log("teste");
		//			/*while (reader.Read ()) {
		//				Debug.Log (reader.GetString (1));
		//			}*/
		//			dbConec.Close ();
		//		}
		//	}
		//}		
	}
}
