using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class DestroyEnemy : MonoBehaviour
{
	Text score = null;
	int currscore;
	void Start ()
	{
		score = GameObject.Find ("GUItext").GetComponent<Text>();

	}

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
				int.TryParse(score.text, out currscore);
				currscore+=100;
				score.text=currscore.ToString();	
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
