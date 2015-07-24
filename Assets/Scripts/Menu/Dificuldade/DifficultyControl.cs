/*
 * Classe para desiginar a dificuldade do jogo.
 */
using UnityEngine;
using System.Collections;

public class DifficultyControl : MonoBehaviour {

	public static string _difficulty;

	void Start () {
		Difficulty(_difficulty);
	}

	void Update () {
	}

	void Difficulty(string Difficulty)
	{
		switch(Difficulty)
		{
			case "Facil":
			print("Velocidade inimigo = 5");
			//BaseEnimy.Speed = 5;
			print("numero maximo de inimigo = 4");
			//ControlEnemiesOnTheScene._numberMaxOfEnemies = 4;
			print("Velocidade jogador = 5");
			//BasePlayer.Speed = 5;
			break;

			case "Medio":
			print("Velocidade inimigo = 6");
			//BaseEnimy.Speed = 6;
			print("numero maximo de inimigo = 5");
			//ControlEnemiesOnTheScene._numberMaxOfEnemies = 5;
			print("Velocidade jogador = 5");
			//BasePlayer.Speed = 5;
			break;

			case "Dificil":
			print("Velocidade inimigo = 7");
			//BaseEnimy.Speed = 7;
			print("numero maximo de inimigo = 6");
			//ControlEnemiesOnTheScene._numberMaxOfEnemies = 6;
			print("Velocidade jogador = 5");
			//BasePlayer.Speed = 5;
			break;
		}
	}
}
