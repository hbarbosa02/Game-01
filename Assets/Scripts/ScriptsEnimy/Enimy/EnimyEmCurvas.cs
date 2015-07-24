/*
 * Classe Contreta para dar movimento em curva para o enimigos
 */
using UnityEngine;
using System.Collections;

public class EnimyEmCurvas : BaseEnimy {

	float X;
	float Y;
	internal override void Start () {
		X = gameObject.transform.position.x ;
	}
	internal override void Update () {
		MoveEnimy(X);
	}
	void MoveEnimy(float x)
	{
//		X += _speed * Time.deltaTime;
//		Y = Mathf.Sin(x) * Mathf.Cos(x);
//		transform.position = Vector3.MoveTowards(new Vector3(X,Y,0), this._Target.position, this._speed * Time.deltaTime);
	}
}
