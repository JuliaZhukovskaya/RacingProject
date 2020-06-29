using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOption : MonoBehaviour {

	void Update () {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
            