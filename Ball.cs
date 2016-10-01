using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	public soundEffects sfx;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
	Cursor.visible=false;
		paddle=GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		sfx=GameObject.FindObjectOfType<soundEffects>();

	}
	
	// Update is called once per frame
	void Update () {


		if (!hasStarted) {
			// Lock the ball relative to the paddle.
			this.transform.position = paddle.transform.position + paddleToBallVector;
			
			// Wait for a mouse press to launch.
			if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space)) {
				print ("Mouse clicked, launch ball");

				hasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);

			}
		}


		}

	void OnCollisionEnter2D(Collision2D collision) {

	Vector2 tweak= new Vector2(Random.Range(-0.2f,0.3f),Random.Range(0f,0.3f));
	this.GetComponent<Rigidbody2D>().velocity+=tweak;
		if(hasStarted){ sfx.Playboing();}
	}
}