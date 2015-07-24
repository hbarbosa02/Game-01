/*
 * Classe Contreta para monitorar o numero de inimigos no jogo e mantar a dificuldade aceitavel.
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ControlEnemiesOnTheScene : MonoBehaviour {
	
	public static int _numberMaxOfEnemies = 6;
	public List<GameObject> _enemies; 
	public float _waitingTime = 1.5f;

	int _numberOfEnemies = 0;
	float _time = 0;
	Vector2 _positionOfEnemies;

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		
	}
	void InstanEnemies(int NumberMaxOfEnemies, GameObject Enemies )
	{
		_time += Time.deltaTime;
		if(_numberOfEnemies <= NumberMaxOfEnemies && _time >= _waitingTime)
		{
			_time = 0;
		}
	}

}
