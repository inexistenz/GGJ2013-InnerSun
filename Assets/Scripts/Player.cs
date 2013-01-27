using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public GameObject mainGame;
	//private bool grounded;
	private Vector3 initialPosition;
	private MainGame mgScript;
	
	// Use this for initializationathf.Log(mushroomRatio + 1.0f)athf.Log(mushroomRatio + 1.0f)
	void Start () {
		initialPosition = transform.position;
		mgScript = mainGame.GetComponent<MainGame>();
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	
/*	void OnCollisionEnter(Collision col) {
		grounded = true;	
	}*/
	
	public void resetPosition() {
		transform.position = initialPosition;
	}
}
