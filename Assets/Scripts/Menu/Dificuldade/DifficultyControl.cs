/*
 * Classe para desiginar a dificuldade do jogo.
 */
using UnityEngine;
using System.Collections;

public class DifficultyControl : MonoBehaviour {

	public static string _difficulty;

	//Varaiveis do modo personalizado vou mudar para uma classe propria para melhorar a organizaçao
	public float SpeedEnimy = 0;
	public int NumberMaxOFEnemies = 0;
	public float WaitingTime = 0;
	//possiveis alteraçeos
	//final das variaveis personalizadas

	void Start () {
		Difficulty(_difficulty);
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
			print("Tempo minimo entre instaciamentos de inimigo e 0.5f");
			//ControlEnemiesOnTheScene._waitingTimeMin = 0.5f;
			print("Velocidade jogador = 5");
			//BasePlayer.Speed = 5;
			break;

			case "Medio":
			print("Velocidade inimigo = 6");
			//BaseEnimy.Speed = 6;
			print("numero maximo de inimigo = 5");
			//ControlEnemiesOnTheScene._numberMaxOfEnemies = 5;
			print("Tempo minimo entre instaciamentos de inimigo e 0.4f");
			//ControlEnemiesOnTheScene._waitingTimeMin = 0.4f;
			print("Velocidade jogador = 5");
			//BasePlayer.Speed = 5;
			break;

			case "Dificil":
			print("Velocidade inimigo = 7");
			//BaseEnimy.Speed = 7;
			print("numero maximo de inimigo = 6");
			//ControlEnemiesOnTheScene._numberMaxOfEnemies = 6;
			print("Tempo minimo entre instaciamentos de inimigo e 0.3f");
			//ControlEnemiesOnTheScene._waitingTimeMin = 0.3f;
			print("Velocidade jogador = 5");
			//BasePlayer.Speed = 5;
			break;

			case "Personalizado":
			print(SpeedEnimy);
			//BaseEnimy.Speed = SpeedEnimy;
			print(NumberMaxOFEnemies);
			//ControlEnemiesOnTheScene._numberMaxOfEnemies = NumberMaxOFEnemies;
			print(WaitingTime);
			//ControlEnemiesOnTheScene._waitingTimeMin = WaitingTimef;
			print("Velocidade jogador = 5");
			//BasePlayer.Speed = 5;
			break;
		}
	}
}
