using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

		void Update () 
		{
				transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
		}

		void Awake() {
				AudioSource[] sources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
				foreach (AudioSource source in sources) {
						Debug.Log(source.gameObject.name);
				}

		}
}