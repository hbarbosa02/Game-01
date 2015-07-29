/*
 * Classe Contreta para executar a rotina de aumento de Velocidade pelo evento SpeedUP
 */
using UnityEngine;
using System.Collections;

public class SpeedUp : ControlerEventos {

	public float _speedUP;
	internal override void Update()
	{
		base.Update ();
		if(ControlerEventos.EventStart == true && ControlerEventos.RandomVelor == 3 && ControlerEventos.EventAtivo == false)
			StartCoroutine(SpeedUP(_speedUP));
	}
	IEnumerator SpeedUP(float SpeedUP)
	{
		//Afirmando que tem um evento em açao nesse moemnto
		ControlerEventos.EventAtivo = true;
		//Evento em açao.
		float InitSpeed = BasePlayer.Speed;
		BasePlayer.Speed += SpeedUP;
		yield return new WaitForSeconds(5);//Duraçao do evento.
		BasePlayer.Speed = InitSpeed;
		//Desativando o Evento.
		ControlerEventos.EventOff();
	}
}
