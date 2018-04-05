using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript{

	private string currentWinner = "Nenhum";
	private GameObject currentMusic;

	public void loadMusic(GameObject m){
		this.currentMusic = m;
	}

	public AudioClip getCurrentMusic(){
		return this.currentMusic.GetComponent<AudioSource>().clip;
	}

	public void setCurrentWinner(string winner){
		this.currentWinner = winner;
	}
}
