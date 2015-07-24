/*
 * Classe Contreta para executa a coroutina de Aumento da velocidade do enimigo.
 */
using UnityEngine;
using System.Collections;

public class SpeedUpEnimy : ControlerEventos {

	public float _speedUP;
	internal override void Update()
	{
		base.Update ();
		StartCoroutine(SpeedUP(ControlerEventos.EventStart, ControlerEventos.RandomVelor, _speedUP));
	}
	IEnumerator SpeedUP(bool StateEvent, int Valor, float SpeedUP)
	{
		if(StateEvent == true && Valor == 4 && ControlerEventos.EventAtivo == false)
		{
			//Afirmando que tem um evento em açao nesse moemnto
			ControlerEventos.EventAtivo = true;
			//Evento em açao.
			float InitSpeed = BaseEnimy.Speed;
			BaseEnimy.Speed += SpeedUP;
			yield return new WaitForSeconds(5);//Duraçao do evento.
			BaseEnimy.Speed = InitSpeed;
			//Desativando o Evento.
			ControlerEventos.EventOff();
		}
	}
}
