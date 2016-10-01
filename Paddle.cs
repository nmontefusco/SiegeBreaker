using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
    
   public float speed;
   public bool autoPlay=false;

    private Ball ball;

    void Start() {
    ball=GameObject.FindObjectOfType<Ball>();
    }
    void Update () { 
    if(!autoPlay) {
    MoveWithMouse(); 
    }else {
    AutoPlay();
        }
        }
     void AutoPlay(){
		float x = Input.GetAxis("Mouse X")*Time.deltaTime*speed;
		transform.Translate (x,0f,0f);
		Vector3 ballPos= ball.transform.position;
		//intially, the temporary vector should equal the player's posistion
		Vector3 clampedPosition=transform.position;
		//now we can manipulate it to clamp the x element
        clampedPosition.x=Mathf.Clamp(ballPos.x,0.5f,15.5f);

        //re-assigning the transform's posistion will clamp it.
        transform.position=clampedPosition;
     }  
 void MoveWithMouse() {
			float x = Input.GetAxis("Mouse X")*Time.deltaTime*speed;
		transform.Translate (x,0f,0f);
		//intially, the temporary vector should equal the player's posistion
		Vector3 clampedPosition=transform.position;
		//now we can manipulate it to clamp the x element
        clampedPosition.x=Mathf.Clamp(transform.position.x,0.5f,15.5f);

        //re-assigning the transform's posistion will clamp it.
        transform.position=clampedPosition;
        }
}
