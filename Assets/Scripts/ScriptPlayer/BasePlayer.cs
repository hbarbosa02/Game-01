/*
 * Classe abstrata basica para movimentos do jogador.
 */
using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {
	//Atributos para rotaçao direita e esquerda//
	[SerializeField]private static bool _flagRotateLeft = false;
	public static bool FlagRotateLeft
	{
		get{return _flagRotateLeft;}
		set{_flagRotateLeft = value;}
	}
	[SerializeField]private static bool _flagRotateRight = false;
	public static bool FlagRotateRight
	{
		get{return _flagRotateRight;}
		set{_flagRotateRight = value;}
	}
	//---------------------------------------------//
	//Variaveis em comun para todos os tipos de player//
	public float _angle = 0;//Variavel de visualizaçao
	public static float Speed = 1;//Variavel de Evento
	//Define o tipo de Escudo
	public Sprite SpriteShied;
	public SpriteRenderer Shield;
	public Sprite SpriteCelulaDeForcaa;
	public SpriteRenderer CelulaDeForca;
	//------------------------------------------------//
	internal virtual void Start()
	{
		Shield.sprite = SpriteShied;
		CelulaDeForca.sprite = SpriteCelulaDeForcaa;
	}
	internal virtual void Update()
	{
		RotatePlayer();
	}
	//Metodo para rotacionar os jogadores//
	void RotatePlayer()
	{
		if(_flagRotateLeft)
		{
			gameObject.transform.eulerAngles = new Vector3(0,0,transform.localRotation.z + _angle);
			_angle -= Speed;
		}
		else if(_flagRotateRight)
		{
			gameObject.transform.eulerAngles = new Vector3(0,0,transform.localRotation.z + _angle);
			_angle += Speed;
		}
	}
	//-----------------------------------------//

}
