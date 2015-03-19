using UnityEngine;
using System.Collections;

public class DestroyShell : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "TankShell(Clone)")
		{
			Destroy(col.gameObject);
		}
	}
}
