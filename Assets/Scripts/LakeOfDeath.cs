using UnityEngine;
using System.Collections;

public class LakeOfDeath : MonoBehaviour {
	
	public GameObject mainGame;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider collider) {
		if(collider.name == "Player") {
			MainGame mgScript = mainGame.GetComponent<MainGame>();
			mgScript.gameOver();
		}
	}
}
