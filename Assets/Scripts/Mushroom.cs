using UnityEngine;
using System.Collections;

public class Mushroom : MonoBehaviour {

	public static int numMushrooms = 0;
	public GameObject mainGame;
	private MainGame mgScript;
	
	// Use this for initialization
	void Start () {
		mgScript = mainGame.GetComponent<MainGame>();
		numMushrooms++;
		mgScript.mushroomCount = numMushrooms;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider collider) {
		numMushrooms--;
		mgScript.mushroomEaten();
		Destroy (gameObject);
	}
}
