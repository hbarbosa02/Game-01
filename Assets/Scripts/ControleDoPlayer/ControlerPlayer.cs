/*
 * Classe Contreta para executar os comandos de movimento do escudo.
 */
using UnityEngine;
using System.Collections;

public class ControlerPlayer : MonoBehaviour {

	//Verifica posiçao da tela para rotacionar
	public string Postiton;
	//Pega o mouse em cima do objeto e o click do mouse no objeto pelo colisor
	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0) && Postiton == "Left"){
			BasePlayer.FlagRotateLeft = true;
		}
		else if(Input.GetMouseButtonDown(0) && Postiton == "Right"){
			BasePlayer.FlagRotateRight = true;
		}
		else if(Input.GetMouseButtonUp(0))
		{
			BasePlayer.FlagRotateLeft = false;
			BasePlayer.FlagRotateRight = false;
		}
	}
}
