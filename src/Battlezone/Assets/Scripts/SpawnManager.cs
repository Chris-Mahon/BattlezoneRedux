using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	public GameObject Enemy1;

	// Use this for initialization
	void Start () {
		StartCoroutine (IEnumerator ());
	}
	
	IEnumerator SpawnEnemny(){
		while (true) {
			//Object to spawn, Initial Vector3 position, no rotation
			Instantiate(Enemy1, Transform.position, Quaternion.identity);
			//Wait time for IEnumerator to be called. Better on CPU overhead
			yield return new WaitForSeconds(5f);
		}
	}
}
