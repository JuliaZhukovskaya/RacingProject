using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTime : MonoBehaviour {

	public int ModeSelection;
	public GameObject AICar1;
	public GameObject AICar2;

	public static bool isTimeMode = false;

	void Start () {
		ModeSelection = ModeSelect.RaceMode;
		if (ModeSelection == 2) {
			isTimeMode = true;
			AICar1.SetActive (false);
			AICar2.SetActive (false);
		}
		
	}
	

}
