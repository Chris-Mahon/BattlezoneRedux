﻿using UnityEngine;
using System.Collections;

public class ShootProjectile : MonoBehaviour {

	public AudioClip shot;
	
	GameObject prefab;
	public float fireRate;
	private float nextFire = 0.0F;
	
	// Use this for initialization
	void Start () 
	{
		prefab = Resources.Load ("TankShell") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			audio.PlayOneShot(shot, 0.7F);
			GameObject TankShell = Instantiate (prefab) as GameObject;
			TankShell.transform.position = transform.position+Camera.main.transform.forward;
			Rigidbody rb = TankShell.GetComponent<Rigidbody>();
			rb.velocity = Camera.main.transform.forward * 40;
			Destroy (TankShell, 5.0f);
		}

	}
	
	
		

}
