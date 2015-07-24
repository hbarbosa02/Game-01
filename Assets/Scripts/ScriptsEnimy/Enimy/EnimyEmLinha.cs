/*
 * Classe Contreta para dar movimento em Linha para o enimigos
 */
using UnityEngine;
using System.Collections;

public class EnimyEmLinha : BaseEnimy {

	internal override void Update () {
		MoveEnimy();
	}
	void MoveEnimy()
	{
		gameObject.transform.position = Vector3.MoveTowards(transform.position, this._Target.position, BaseEnimy.Speed * Time.deltaTime);
	}
}
