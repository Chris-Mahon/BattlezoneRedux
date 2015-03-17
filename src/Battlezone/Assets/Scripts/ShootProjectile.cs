using UnityEngine;
using System.Collections;

public class ShootProjectile : MonoBehaviour {
	
	GameObject prefab;
	
	// Use this for initialization
	void Start () {
		prefab = Resources.Load ("TankShell") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject TankShell = Instantiate (prefab) as GameObject;
			TankShell.transform.position = transform.position+Camera.main.transform.forward;
			Rigidbody rb = TankShell.GetComponent<Rigidbody>();
			rb.velocity = Camera.main.transform.forward * 40;
		}
	}
}
