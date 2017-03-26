using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollPanel : MonoBehaviour {

	public float scrollRate;
	public ScrollRect myScrollRect;

	// Use this for initialization
	void Start () {
	
		myScrollRect.verticalNormalizedPosition = 1.0f;
	}

	// Update is called once per frame
	void Update () {

		myScrollRect.verticalNormalizedPosition -= scrollRate * Time.deltaTime;

		if (myScrollRect.verticalNormalizedPosition < 0.0f) {

			myScrollRect.verticalNormalizedPosition = 0.0f;
		}

		Debug.Log( "pct: "+myScrollRect.verticalNormalizedPosition );

		/*

		transform.Translate (new Vector3 (0, scrollRate*Time.deltaTime, 0));

		Vector3[] fourCornersArray = new Vector3[4];
		GetComponent<RectTransform> ().GetWorldCorners (fourCornersArray);

		RectTransform t = GetComponent<RectTransform> ();

		//Debug.Log( "top: "+fourCornersArray[0].y );
		//Debug.Log( "bottom: "+fourCornersArray[2].y );

		Debug.Log( "rect: "+t.rect);
		//Debug.Log( "bottom: "+fourCornersArray[2].y );

		*/
	}
}
