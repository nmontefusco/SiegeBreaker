using UnityEngine;
using System.Collections;

	public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;
	public static int breakableCount=0;

	private int timesHit;
	private MenuManager menuManager;
	private bool isBreakable;
	public soundEffects sfx;
	public GameObject smoke;

	void Start () {

	isBreakable = (this.tag=="Breakable");
	//keep track of breakable bricks

	if (isBreakable) {
	breakableCount++;
	print(breakableCount);
	}
	timesHit=0;
	menuManager=GameObject.FindObjectOfType<MenuManager>();
	sfx=GameObject.FindObjectOfType<soundEffects>();

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col) { 
	if(isBreakable) {
	handleHits();
 	}
}

	void handleHits(){
		timesHit++;
		int maxHits=hitSprites.Length+1;
		if(timesHit>= maxHits){
		breakableCount--;
	sfx.Playdestroyed();
	menuManager.BrickDestroyed();
	PuffSmoke();
	Destroy(gameObject);
	} else {
	LoadSprites();
	}

	}

	void PuffSmoke(){
		GameObject smokePuff = Instantiate(smoke, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;
	smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
	}

	void LoadSprites(){
	int spriteIndex= timesHit-1;
	if(hitSprites[spriteIndex] !=null) {
	this.GetComponent<SpriteRenderer>().sprite= hitSprites[spriteIndex];
} else {
Debug.LogError("Brick sprite missing");
}
}
//to do: define a win condition.
	void simulateWin() {
	menuManager.LoadNextLevel();
	}
}