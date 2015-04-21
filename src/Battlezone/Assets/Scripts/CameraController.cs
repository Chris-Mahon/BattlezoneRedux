//Imports
using UnityEngine;
using System.Collections;

//Class for controlling the movement of the Camera
public class CameraController : MonoBehaviour
{
 	//Definitions
	private float Move;//
	private float Rotation;

	private float RotSpeed;//Speed of rotation
	private float Speed; //Speed that the tank will move
	Vector3 spawnSpot = new Vector3(0f,0.5f,0f);
	public static int score = 0;
	// Use this for initialization
	void Start () 
	{//Initialising variables
		RotSpeed = 2;
		Speed = 0;

	}//End of Start
	
	// Update is called once per frame
	void Update () 
	{//Game Loop
		float Move = Input.GetAxis ("Vertical"); //Gets input on the Vertical Axis (Up and down arrow)
		float Rotation = Input.GetAxis("Horizontal"); //Gets input on the Horizontal axis (left and right arrow)
		/*
		 * Removed this as it conflicts with shooting projectiles with spacebar 
		 * Is currently unecessary
		if (Input.GetKeyDown ("space")) 
		{
			GameObject cubeSpawn = (GameObject)Instantiate(Resources.Load("Spike"), spawnSpot, transform.rotation);
		}
		*/
		transform.Rotate(0, Rotation*RotSpeed, 0); //Rotates the camera left or right depending on input
		Speed = (float)(Move*1.5); //Sets the movement speed
		Vector3 Direction = Movement(Speed); //Sets Velocity
		Direction = transform.rotation * Direction; //Makes it a relative movement

		CharacterController Control = GetComponent<CharacterController>(); //Contacts the character control

		Control.SimpleMove(Direction); //Moves the player

	}//End of Update

	Vector3 Movement(float Number)
	{
		return(new Vector3 (0, 0, Number));
	}

}
