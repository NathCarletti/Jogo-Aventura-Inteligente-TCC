using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CamP : MonoBehaviour {
	public List<Object> blocos;
	public GameObject chao;
    public Transform player;
    public float offset, x;
	public int teste;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
		x= -13.45f;
		while(x<0){
			x+=0.19f;
			blocos.Add(Instantiate(chao,new Vector3(x, chao.transform.position.y, 0f),Quaternion.identity));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
        //Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime);
        transform.rotation = Quaternion.identity;
        transform.position = player.position - Vector3.forward * 20 + Vector3.right * offset;
	}
}
