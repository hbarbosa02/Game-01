﻿/*
 * Classe Contreta para executa a coroutina de inverçao do controle.
 */
using UnityEngine;
using System.Collections;

public class InveteDirection : ControlerEventos {

	float DurationEvent = 0;
	internal override void Update ()
	{
		base.Update ();
		StartCoroutine(inveteDirection(ControlerEventos.EventStart, ControlerEventos.RandomVelor));
	}
	IEnumerator inveteDirection(bool StateEvent, int Valor)
	{
		if(StateEvent == true && Valor == 0 && ControlerEventos.EventAtivo == false && DurationEvent <= 10)
		{
			DurationEvent += Time.deltaTime;
			if(BasePlayer.FlagRotateLeft)
				BasePlayer.Speed *= -1;

			else if(BasePlayer.FlagRotateRight)
				BasePlayer.Speed *= -1;
		}
		else if(DurationEvent > 10)
		{
			DurationEvent = 0;
			ControlerEventos.EventOff();
			yield return null;
		}
	}
}
