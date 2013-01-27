using UnityEngine;
using System.Collections;

public class MainGame : MonoBehaviour {
	
	public float lightIntensity = 8f;
	public float startingFishEyeStrength = 1.6f;
	private float currentFishEyeStrength;
	private float fishEyeDecrement;
	public GameObject player;
	public GameObject innerSun;
	public GameObject cam;
	public GameObject playerLight;
	public int mushroomCount;
	
	private bool glow;
	public Fisheye fish;
	public Bloom bloom;
	public Player p;
	
	// Use this for initialization
	void Start () {
		p = player.GetComponent<Player>();
		fish = cam.GetComponent<Fisheye>();
		bloom = cam.GetComponent<Bloom>();
		fish.strengthX = fish.strengthY = currentFishEyeStrength = startingFishEyeStrength;
		playerLight.light.intensity = 0f;
		playerLight.light.range = 10f;
		//		player.light.intensity = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		float intensity = innerSun.light.intensity;
		bloom.bloomThreshhold = intensity / 16f + 0.5f;	
		bloom.bloomIntensity = lightIntensity - intensity;
		fish.strengthX = fish.strengthY = currentFishEyeStrength * intensity/lightIntensity;
		//ebug.Log (currentFishEyeStrength);
	}
	
	public void mushroomEaten() {
		float mushroomRatio = (float) Mushroom.numMushrooms / mushroomCount;
		float datLog = Mathf.Log(mushroomRatio + 1.0f);
		Debug.Log (datLog);
		currentFishEyeStrength = startingFishEyeStrength * datLog;
		/*playerLight.light.intensity = 16.0f - mushroomRatio * 16.0f;
		playerLight.light.range = 10f + mushroomRatio * 16.0f;
		Debug.Log ("Intensity: " + 	playerLight.light.intensity);*/
	}
	
	public void gameOver() {	
		p.resetPosition();
	}
}
