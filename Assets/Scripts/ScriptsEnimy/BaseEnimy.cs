/*
 * Classe abstrata basica para contruçao do personagem.
 */
using UnityEngine;
using System.Collections;

public class BaseEnimy : MonoBehaviour {

	public Transform _Target;
	public static float Speed;
	public string _tag;
	internal bool _flagDestroyer;
	// Use this for initialization
	internal virtual void Start () {
	
	}
	// Update is called once per frame
	internal virtual void Update () {
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == _tag)
		{
			_flagDestroyer = true;
			ControlEnemiesOnTheScene._numberOfEnemies --;
		}
		else if(other.gameObject.tag != _tag)
		{

		}
	}
}
