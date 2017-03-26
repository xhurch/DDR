using UnityEngine;
using System.Collections;

public class LightControls : MonoBehaviour {

	//SerialControl serialControl;
	private int lightMode;
	private float lightLevel;

	// Use this for initialization
	void Start () {

		lightMode = 0; 
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			Trigger();
		}
			
		if (lightMode == 0) {

			lightLevel -= 0.8f * Time.deltaTime;

			if (lightLevel <= 0.0f)
				lightLevel = 0.0f;
		
		} else {

			lightLevel += 1.2f * Time.deltaTime;

			if (lightLevel >= 1.0f) {

				lightMode = 0;
			}
		}

		//Debug.Log("ll: "+lightLevel);
	}

	void Trigger(){

		lightMode = 1;
	}
}
