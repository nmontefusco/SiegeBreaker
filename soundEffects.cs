using UnityEngine;
using System.Collections;

public class soundEffects : MonoBehaviour {
static soundEffects instance=null;
public AudioClip destroyedBlock;
public AudioClip victory;

	// Use this for initialization

	void Start () {

   if(instance!=null) {
   Destroy(gameObject);
   }else{
   instance=this;

    }
   GameObject.DontDestroyOnLoad(gameObject);		
	}
	

	public void Playboing(){
	GetComponent<AudioSource>().Play();
	}

	public void Playdestroyed(){
	AudioSource.PlayClipAtPoint(destroyedBlock,Camera.main.transform.position);
	}



public void Stageclear(){
	AudioSource.PlayClipAtPoint(victory,Camera.main.transform.position);
	}


	}

