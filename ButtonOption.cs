﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOption : MonoBehaviour {
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void TrackSelect()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
  
        Application.Quit();
        
    }
  
    public void Track01()
    {
        SceneManager.LoadScene(2);
    }
    public void Track02()
    {
        SceneManager.LoadScene(3);
    }
	public void CreditScene()
	{
		SceneManager.LoadScene(4);
	}
}
