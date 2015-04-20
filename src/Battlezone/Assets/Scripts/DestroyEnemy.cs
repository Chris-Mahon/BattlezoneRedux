using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Obstacle") 
		{
			Destroy (gameObject);
		} 
		else if (col.gameObject.name.Contains ("Border")) 
		{
			Destroy(gameObject);
		}
		else if(gameObject.name == "EnemyTankShell(Clone)")
		{
			if (col.gameObject.name == "Player") 
			{
				print("I hit something!");
				Destroy(gameObject);
			}
			if (col.gameObject.name == "TankShell(Clone)")
			{
				Destroy(col.gameObject);
				Destroy(gameObject);

			}

		}
		else if(gameObject.name == "TankShell(Clone)")
		{
			if (col.gameObject.name == "Enemy(Clone)") 
			{
				Destroy(col.gameObject);
				Destroy(gameObject);
			}
			if (col.gameObject.name == "TankShell(Clone)")
			{
				Destroy(col.gameObject);
				Destroy(gameObject);
			}
			
		}

	}

}
