using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject NormalBody;
    public GameObject Police;
    public int CarImport;
    void Start () {
        CarImport = GlobalCar.CarTyp;
        if(CarImport == 1)
        {
            NormalBody.SetActive(false);
            Police.SetActive(false);
            RedBody.SetActive(true);
        }
        if (CarImport == 2)
        {
            Police.SetActive(false);
            NormalBody.SetActive(false);
            RedBody.SetActive(false);
            BlueBody.SetActive(true);
        }
        if (CarImport == 3)
        {
            NormalBody.SetActive(false);
            RedBody.SetActive(false);
            BlueBody.SetActive(false);
            Police.SetActive(true);
        }
    }
	
}
