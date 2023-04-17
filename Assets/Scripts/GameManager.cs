using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public Text scoreText;
	public Text gameOverText;
	int playerScore = 0;
	public void AddScore()
	{
		playerScore++;
		// This converts the score (a number) into a string
		scoreText.text = playerScore.ToString();
	}
	public void PlayerDied()
	{
		gameOverText.enabled = true;
		// This freezes the game
		Time.timeScale = 0;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
