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
	void Medio()
	{
		DifficultyControl._difficulty = "Medio";
	}
	void Dificil()
	{
		DifficultyControl._difficulty = "Dificil";
	}
}
