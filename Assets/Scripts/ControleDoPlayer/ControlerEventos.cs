/*
 * Classe abstrata basica para Criarçao de Eventos do jogo.
 */
using UnityEngine;
using System.Collections;

public class ControlerEventos : MonoBehaviour {

	public string _tag;
	public static int RandomVelor;
	//Atributos Internos da Arvore da Classe Eventos
	internal static bool _eventStart = false;
	internal static bool EventStart
	{
		set{_eventStart = value;}
		get{return _eventStart;}
	}

	internal static bool _eventAtivo = false;
	internal static bool EventAtivo
	{
		set{_eventAtivo = value;}
		get{return _eventAtivo;}
	}

	internal virtual void Update () {
	}
	//----------------------------------------------
	public static void EventOff()
	{
		_eventStart = false;
		_eventAtivo = false;
	}
	public void ActiveEvento()
	{
		if(ControlCoins._amountOfGold >= 10)//Condiçao para saber se ele tem moedas suficiente para tivar algum Evento
		{
			ControlCoins._amountOfGold -= 10;
			RandomVelor = Random.Range(0,4);
			_eventStart = true;
		}
	}
}
