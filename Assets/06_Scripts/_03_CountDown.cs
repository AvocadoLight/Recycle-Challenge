using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class _03_CountDown : MonoBehaviour {

	int time = 3;
	public Sprite Three;
	public Sprite Two;
	public Sprite One;
	public Sprite Go;
	public GameObject Btn;
	public Image CountDownImg;
	public string SceneName;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void countDown() {
		Btn.SetActive (false);
		CountDownImg.gameObject.SetActive (true);
		InvokeRepeating ("timer", 1, 1);

	}

	public void timer() {

		time -= 1;

		switch (time) {
		case 3:
			CountDownImg.sprite = Three;
			break;
		case 2:
			CountDownImg.sprite = Two;
			break;
		case 1:
			CountDownImg.sprite = One;
			break;
		case 0:
			CountDownImg.sprite = Go;
			SceneManager.LoadScene (SceneName);
			break;
		default:
			break;
		}



	}

}
