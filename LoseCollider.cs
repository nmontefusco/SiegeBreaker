using UnityEngine;
using System.Collections;
 
public class LoseCollider : MonoBehaviour {
	private MenuManager levelManager;
		
		void Start() {
		levelManager=GameObject.FindObjectOfType<MenuManager>();

		}
	void OnTriggerEnter2D(Collider2D Trigger) {
	Cursor.visible=true;
	levelManager.Loadlevel ("Lose");

	}

	void OnCollisonEnter2D(Collision2D Collision) {

		
	}
}
