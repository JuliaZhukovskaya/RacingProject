using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedObject : MonoBehaviour {

	public int policeSelect;
	public GameObject FakePolice;

	void Start () {
		policeSelect = PlayerPrefs.GetInt ("PoliceBought");
		if (policeSelect == 500) {
			FakePolice.SetActive (false);
		}
		
	}
	

}
