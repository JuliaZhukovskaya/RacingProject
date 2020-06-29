using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class FinishRace : MonoBehaviour {

	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public AudioSource FinishMusic;
	public GameObject OtherCar1;
	public GameObject OtherCar2;


	private void OnTriggerEnter(){
		if (ModeTime.isTimeMode == true) {
		} else {
			this.GetComponent<BoxCollider> ().enabled = false;
			MyCar.SetActive (false);
			OtherCar1.SetActive (false);
			OtherCar2.SetActive (false);
			CompleteTrig.SetActive (false);
			CarController.m_Topspeed = 0.0f;
			MyCar.GetComponent<CarController> ().enabled = false;
			OtherCar1.GetComponent<CarController> ().enabled = false;
			OtherCar2.GetComponent<CarController> ().enabled = false;
			MyCar.GetComponent<CarUserControl> ().enabled = false;
			MyCar.SetActive (true);
			OtherCar1.SetActive (true);
			OtherCar2.SetActive (true);
			MyCar.GetComponent<CarAudio> ().StopSound ();
			MyCar.GetComponent<CarAudio> ().enabled = false;
			OtherCar1.GetComponent<CarAudio> ().StopSound ();
			OtherCar2.GetComponent<CarAudio> ().StopSound ();
			OtherCar1.GetComponent<CarAudio> ().enabled = false;
			OtherCar2.GetComponent<CarAudio> ().enabled = false;
			FinishCam.SetActive (true);
			LevelMusic.SetActive (false);
			ViewModes.SetActive (false);
			FinishMusic.Play ();
			GlobalCash.TotalCash += 100;
			PlayerPrefs.SetInt ("SavedCash", GlobalCash.TotalCash);
		}
		StartCoroutine(TheEnd());
	}

	IEnumerator TheEnd(){
		yield return new WaitForSeconds (10);
		SceneManager.LoadScene (0);
	}

}
