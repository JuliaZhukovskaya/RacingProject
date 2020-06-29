using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThePosDown : MonoBehaviour {

	public GameObject PositionDisplay;

	void OnTriggerExit(Collider other){
		if (other.tag == "CarPos") {
			PositionDisplay.GetComponent<Text> ().text = "3rd Place";
		}
	}

}
