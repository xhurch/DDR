using UnityEngine;
using System.Collections;

public class ImgLayout : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		float yPosition = 0;


		foreach (Transform child in transform)
		{
			

			//Debug.Log (child.);
			Debug.Log ("pos: "+child.transform.position);
			Debug.Log ("transform "+child.transform.GetComponent<RectTransform>().rect);

			child.transform.position.Set (0, yPosition, 0);

			yPosition += child.transform.GetComponent<RectTransform> ().rect.height + 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
