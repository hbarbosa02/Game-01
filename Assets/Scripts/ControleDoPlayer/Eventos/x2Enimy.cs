using UnityEngine;
using System.Collections;

public class x2Enimy : ControlerEventos {
	
	internal override void Update()
	{
		base.Update ();
		if(ControlerEventos.EventStart == true && ControlerEventos.RandomVelor == 5 && ControlerEventos.EventAtivo == false)
			StartCoroutine(X2Enimy());
	}
	IEnumerator X2Enimy()
	{
		ControlEnemiesOnTheScene._numberMaxOfEnemies *= 2;
		yield return new WaitForSeconds(5);
	}
}
