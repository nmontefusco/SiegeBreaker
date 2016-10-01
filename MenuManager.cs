using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {
private soundEffects sfx;
public void Start(){
		sfx=GameObject.FindObjectOfType<soundEffects>();
		}

	public void Loadlevel(string name) {
		Brick.breakableCount = 0;
		SceneManager.LoadScene(name);

	}


	public void QuitGame(){
			Application.Quit();
	
	}

public void LoadNextLevel(){
Brick.breakableCount = 0;
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

}

public void BrickDestroyed() {
if(Brick.breakableCount<=0){
			
			LoadNextLevel();

			}
 	}
 }
