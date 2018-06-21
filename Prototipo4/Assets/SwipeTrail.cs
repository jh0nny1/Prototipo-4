using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTrail : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved || Input.GetMouseButton (0)) {
		
			Plane ojbPlane = new Plane (Camera.main.transform.forward * -1, this.transform.position);

			Ray nRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			float RayDistance;
			if (ojbPlane.Raycast (nRay, out RayDistance)) {
				this.transform.position = nRay.GetPoint (RayDistance);
			}
		} 
	}
}
