using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class _01_ClickMuteBtn : MonoBehaviour {

	public static bool flag = false;
	public Button muteBtn;
	public Image image;


	// Use this for initialization
	void Start () {

		muteBtn = this.GetComponent<Button> ();
		image = this.GetComponent<Image> ();
		
	}

	
	// Update is called once per frame
	void Update () {
		

	}

	void muteBtnIsClick () {

		if (flag) {


		} else {

			flag = true;
			image.overrideSprite = Resources.Load ("04_UI/01_MainMenu/01_button3_bgm_2",typeof(Sprite)) as Sprite;

		}
	}
}
