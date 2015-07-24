/*
 * Classe abstrata basica para Criarçao de Eventos do jogo.
 */
using UnityEngine;
using System.Collections;

public class ControlerEventos : MonoBehaviour {

	public string _tag;
	//Atributos Internos da Arvore da Classe Eventos
	internal static bool _eventStart = true;
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
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == _tag)
		{
			_eventStart = true;
		}
	}
}
