using UnityEngine;
using System.Collections;

public class HowToStart : MonoBehaviour {
private MenuManager menuManager;
	// Use this for initialization
	void Start () {
		menuManager=GameObject.FindObjectOfType<MenuManager>();
		}
	void OnTriggerEnter2D(Collider2D Trigger) {
	menuManager.Loadlevel("level_01");
	}
	

}
