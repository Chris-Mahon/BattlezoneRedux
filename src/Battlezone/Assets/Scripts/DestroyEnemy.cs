using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		print(col.gameObject.name);
		if(col.gameObject.name == "Enemy(Clone)")
		{
			Destroy(col.gameObject);
		}
		if(col.gameObject.name == "Obstacle")
		{
			Destroy(gameObject);
		}
	}
}
