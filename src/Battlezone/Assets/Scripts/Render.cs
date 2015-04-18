using UnityEngine;
using System.Collections;
using Vectrosity;


public class Render : MonoBehaviour 
{
	Vector3[] renderlines = {new Vector3(1f, -1f, 1f), new Vector3(-1f, -1f, 1f), new Vector3(-1f, -1f, 1f), new Vector3(-1f, -1f, -1f), new Vector3(-1f, -1f, -1f), new Vector3(1f, -1f, -1f), new Vector3(1f, -1f, -1f), new Vector3(1f, -1f, 1f), new Vector3(-1f, -1f, -1f), new Vector3(0.004f, 1f, -0.141f), new Vector3(0.004f, 1f, -0.141f), new Vector3(1f, -1f, -1f), new Vector3(0.004f, 1f, -0.141f), new Vector3(1f, -1f, 1f), new Vector3(-1f, -1f, 1f), new Vector3(0.004f, 1f, -0.141f)};

	// Use this for initialization
	void Start () 
	{
		renderer.enabled = true;
		VectorLine VLine = new VectorLine ("Lines", renderlines, null, 2);
		VLine.color = Color.green;
		VectorManager VMan = new VectorManager ();
		VectorManager.ObjectSetup(gameObject, VLine, Visibility.Static, Brightness.Fog, true);
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
