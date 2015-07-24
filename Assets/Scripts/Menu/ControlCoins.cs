/*
 * Classe com a funçao de Controlar a quantidade de gold do jogador.
 */
using UnityEngine;
using System.Collections;

public class ControlCoins : MonoBehaviour {

	public static int _amountOfGold = 0;
		 
	void Update () {
		PlayerPrefs.SetInt("Gold", _amountOfGold);
	}
}
