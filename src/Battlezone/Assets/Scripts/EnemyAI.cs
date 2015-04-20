using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	float speed;

	GameObject prefab;

	bool waiting;

	// Use this for initialization
	void Start () 
	{
		Vector3 PlayerLocale = GameObject.Find("Player").transform.position;
		print (PlayerLocale.x);
		transform.LookAt(PlayerLocale);
		speed = 0.5f;
		prefab = Resources.Load ("TankShell") as GameObject;
		waiting = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!waiting) 
		{
			StartCoroutine(MoveOrFire());
		}
	}

	IEnumerator MoveOrFire()
	{
		Vector3 PlayerLocale = GameObject.Find("Player").transform.position;
		transform.LookAt(PlayerLocale);
		float distance = Vector3.Distance (GameObject.Find("Player").transform.position, gameObject.transform.position);
		
		if (distance > 20) 
		{
			speed = 0.5f;
			transform.position = Vector3.MoveTowards(transform.position, PlayerLocale, speed * Time.deltaTime);
		}
		else 
		{
			waiting = true;
			GameObject TankShell = Instantiate (prefab) as GameObject;
			TankShell.transform.position = transform.position + gameObject.transform.forward;
			TankShell.name = "Enemy" + TankShell.name;
			Rigidbody rb = TankShell.GetComponent<Rigidbody>();
			rb.velocity = gameObject.transform.forward * 40;
			Destroy (TankShell, 5.0f);

			yield return new WaitForSeconds(5);
			waiting = false;
		}

	}
}
