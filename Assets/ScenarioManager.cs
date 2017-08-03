using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioManager : MonoBehaviour {
	[Header("GameObjects")]
	[SerializeField] private Transform groundCheck;
	public List<Transform> ground;
	public float xMax = 22f;
	public float xMin = 1f; 

	// Use this for initialization
	void Start () {
		groundCheck.GetComponent<GroundRespawnController>().changeGroundPosition = ChangeGround;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangeGround(GameObject other)
	{
		ground.Find(other.transform);
		other.gameObject.transform.position = new Vector2(
		 	other.gameObject.transform.position.x * -1,
		 	other.gameObject.transform.position.y);
	}
}
