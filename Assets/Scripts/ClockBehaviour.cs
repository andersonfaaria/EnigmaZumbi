using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClockBehaviour : MonoBehaviour {
	public float timeInSeconds;
	Image image;
	float startTime;
	
	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		image.fillAmount = 1f - (Time.time - startTime) / timeInSeconds;
		
		if (image.fillAmount == 0f)
			Application.LoadLevel (Application.loadedLevel);
	}
}
