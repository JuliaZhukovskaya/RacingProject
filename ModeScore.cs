using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour {

	public int ModeSelection;
	public GameObject RaceUI;
	public GameObject ScoreUI;
	public GameObject AICar1;
	public GameObject AICar2;
	public static int CurrentScore;
	public int IntervalScore;
	public GameObject ScoreValue;
	public GameObject ScoreObjects;

	void Start () {
		ModeSelection = ModeSelect.RaceMode;
		if (ModeSelection == 1) {
			RaceUI.SetActive (false);
			ScoreUI.SetActive (true);
			AICar1.SetActive (false);
			AICar2.SetActive (false);
			ScoreObjects.SetActive (true);
		}
		
	}
	

	void Update () {
		IntervalScore = CurrentScore;
		ScoreValue.GetComponent<Text> ().text = "" + IntervalScore;
	}
}
