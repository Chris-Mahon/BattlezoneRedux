using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour 
{
	
	bool isSpawning = false;
	public float minTime = 5.0f;
	public float maxTime = 15.0f;
	public GameObject Enemy;  // The enemy prefab
	public int amount = 0;
	
	IEnumerator SpawnObject(float seconds)
	{
		Debug.Log ("Waiting for " + seconds + " seconds");
		
		yield return new WaitForSeconds(seconds);
		Instantiate(Enemy, transform.position+Camera.main.transform.forward*10, transform.rotation);
		//We've spawned, so now we could start another spawn     
		isSpawning = false;
	}
	
	void Update () 
	{
		//We only want to spawn one at a time, so make sure we're not already making that call
		if(! isSpawning)
		{
			isSpawning = true; //Yep, we're going to spawn
			StartCoroutine(SpawnObject(Random.Range(minTime, maxTime)));
			amount++;
		}
	}

	void OnGUI()
	{
		GUI.Box (new Rect(Screen.width/2 - 220, Screen.width/2 - 240, 50, 25), amount.ToString());
	}
}
