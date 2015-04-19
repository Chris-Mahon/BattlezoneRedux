using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Vector3 PlayerLocale = GameObject.Find("Player").transform.position;
		print (PlayerLocale.x);
		transform.LookAt(PlayerLocale);
		float speed = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 PlayerLocale = GameObject.Find("Player").transform.position;
		transform.LookAt(PlayerLocale);
		float distance = Vector3.Distance (GameObject.Find("Player").transform.position, gameObject.transform.position);
		print ("Distance is", distance);

		if (distance > 10) 
		{
			speed = 0.0f;
			transform.position = Vector3.MoveTowards(transform.position, PlayerLocale, speed * Time.deltaTime);
		}
		else 
		{
			WaitForSeconds(5);
			print("Hi");
			speed = 0.5f;
		}
	}
}
