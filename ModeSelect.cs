using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour {

 
	public static int RaceMode;
	public GameObject CarSelect;

	public void ScoreMode(){
		RaceMode = 1;
		CarSelect.SetActive (true);
	}

	public void TimeMode(){
		RaceMode = 2;
		CarSelect.SetActive (true);
	}
		
	public void TheRaceMode(){
		RaceMode = 0;
		CarSelect.SetActive (true);
	}
}
