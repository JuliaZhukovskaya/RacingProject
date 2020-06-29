using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditFinish : MonoBehaviour {


	void Start () {
		StartCoroutine (FinishCredits ());
	}

	IEnumerator FinishCredits () {
		yield return new WaitForSeconds (6);
		SceneManager.LoadScene (0);
	}
}
