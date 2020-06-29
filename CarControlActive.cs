using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour {
	
	public GameObject CarControl;
	public GameObject DreamCar01;
	public GameObject DreamCar02;

	void Start () {
		CarControl.GetComponent<CarUserControl> ().enabled = true;
		DreamCar01.GetComponent<CarAIControl> ().enabled = true;
		DreamCar02.GetComponent<CarAIControl> ().enabled = true;
	}

}
