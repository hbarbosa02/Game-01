﻿/*
 * Classe com a funçao de Controlar a quantidade de inimigos derrotados por vc.
 */
using UnityEngine;
using System.Collections;

public class EnemiesOfPoints : MonoBehaviour {

	public static int  _tipo1 = 0;

	void Update () {
		PlayerPrefs.SetInt("Tipo1", _tipo1);
	}
}
