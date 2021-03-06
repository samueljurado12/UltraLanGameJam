﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager {

	public static int player1Score = 0;
	public static int player2Score = 0;

	public static void ResetScore () {
		player1Score = 0;
		player2Score = 0;
	}

    public static void NextScene() {
        if (ScoreManager.player1Score >= 3) {
            GameSceneManager.LoadPlayer1Win();
        } else if (ScoreManager.player2Score >= 3) {
            GameSceneManager.LoadPlayer2Win();
        } else {
            GameSceneManager.LoadNextRandomLevel();
        }
    }
}
