using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelChange : MonoBehaviour {
    // to cnange Camera Perspective      
    public GameObject NoramlCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;
    
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            if(CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            } StartCoroutine(ModeChange());
     
        }
	}
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0)
        {
            NoramlCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NoramlCam.SetActive(false);
        }
        if (CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }
}
