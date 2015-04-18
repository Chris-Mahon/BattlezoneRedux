using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Vector3 PlayerLocale = GameObject.Find("Player").transform.position;
		print (PlayerLocale.x);
		transform.LookAt(PlayerLocale);
	}
	
	// Update is called once per frame
	void Update () 
	{

		Vector3 PlayerLocale = GameObject.Find("Player").transform.position;
		transform.LookAt(PlayerLocale);
		transform.position = Vector3.MoveTowards(transform.position, PlayerLocale, 0.5f*Time.deltaTime);

	}
}
