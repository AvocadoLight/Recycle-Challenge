﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _02_LoadScene : MonoBehaviour {
	
	public void LoadSceneByClick(string sceneName){

		SceneManager.LoadScene (sceneName);


	}

}
