using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClockBehaviour2 : MonoBehaviour {
	
	Text text;
	public float minutes = 10;
	public float seconds = 0;
	bool isPaused = false;
	
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isPaused == false) {
			if (seconds <= 0) {
				seconds = 59;
			
				if (minutes >= 1) {
					minutes --;
				} else {
					minutes = 0;
					seconds = 0;
					text.text = minutes.ToString ("f0") + ":0" + seconds.ToString ("00");
				}
			} else {
				seconds -= Time.deltaTime;
				string niceTime = string.Format ("{0:00}:{1:00}", minutes, seconds);
				text.text = niceTime;
			}
		} 
	}
}