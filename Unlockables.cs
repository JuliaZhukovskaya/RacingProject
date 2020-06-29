using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockables : MonoBehaviour {

	public GameObject PoliceButton;
	public int cashValue;

	void Update () {
		cashValue = GlobalCash.TotalCash;
		if (cashValue >= 500) {
			PoliceButton.GetComponent<Button> ().interactable = true;
		}
	}

	public void PoliceUnlock(){
		PoliceButton.SetActive (false);
		cashValue -= 500;
		GlobalCash.TotalCash -= 500;
		PlayerPrefs.SetInt ("SavedCash", GlobalCash.TotalCash);
		PlayerPrefs.SetInt ("PoliceBought", 500);
	}
}
