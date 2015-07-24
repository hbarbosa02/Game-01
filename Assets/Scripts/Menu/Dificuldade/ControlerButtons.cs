/*
 * Classe com a funçoes de cada butao.
 */
using UnityEngine;
using System.Collections;

public class ControlerButtons : MonoBehaviour {

	public void Facil()
	{
		DifficultyControl._difficulty = "Facil";	
	}
	public void Medio()
	{
		DifficultyControl._difficulty = "Medio";
	}
	public void Dificil()
	{
		DifficultyControl._difficulty = "Dificil";
	}
	public void ChangeDifficulty()
	{
	}
	public void Ponctuation()
	{
	}
	public void Close()
	{
		Application.Quit();
	}
}
