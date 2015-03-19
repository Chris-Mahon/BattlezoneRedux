using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Enemy(Clone)")
		{
			Destroy(col.gameObject);
		}
	}
}
