using UnityEngine;
using System.Collections;

public class bookBehaviour : MonoBehaviour {
	// Example script that could be attached to the Player
	// Example requires coins to be tagged "Coin" for this to work.
	public int score;
	public AudioSource coinAudio;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			score += 100;
			coinAudio.Play();
			Destroy(this.gameObject, 0.2f); // Or whatever way you want to remove the coin.
		}
	}
}
