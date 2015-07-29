/*
 * Classe Contreta para executa a coroutina de inverçao do controle.
 */
using UnityEngine;
using System.Collections;

public class InverteDirection : ControlerEventos {

	float DurationEvent = 0;
	internal override void Update ()
	{
		base.Update ();
		if(ControlerEventos.EventStart == true && ControlerEventos.RandomVelor == 0 && ControlerEventos.EventAtivo == false)
			StartCoroutine(inveteDirection());
	}
	IEnumerator inveteDirection()
	{
		if(DurationEvent <= 10)
		{
			DurationEvent += Time.deltaTime;
			if(BasePlayer.FlagRotateLeft)
				BasePlayer.Speed = -(BasePlayer.Speed);

			else if(BasePlayer.FlagRotateRight)
				BasePlayer.Speed = -(BasePlayer.Speed);
		}
		else if(DurationEvent > 10)
		{
			DurationEvent = 0;
			ControlerEventos.EventOff();
			yield return null;
		}
	}
}
