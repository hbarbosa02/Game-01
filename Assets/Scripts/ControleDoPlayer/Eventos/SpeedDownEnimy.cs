/*
 * Classe Contreta para executa a coroutina de Diminuir da velocidade do inimigo.
 */
using UnityEngine;
using System.Collections;

public class SpeedDownEnimy : ControlerEventos {

	public float _speedDown;
	internal override void Update()
	{
		base.Update ();
		StartCoroutine(SpeedDOWN(ControlerEventos.EventStart, _speedDown));
	}
	IEnumerator SpeedDOWN(bool StateEvent, float SpeedUP)
	{
		if(StateEvent == true && ControlerEventos.EventAtivo == false)
		{
			//Afirmando que tem um evento em açao nesse moemnto
			ControlerEventos.EventAtivo = true;
			//Evento em açao.
			float InitSpeed = BaseEnimy.Speed;
			BaseEnimy.Speed -= SpeedUP;
			yield return new WaitForSeconds(5);//Duraçao do evento.
			BaseEnimy.Speed = InitSpeed;
			//Desativando o Evento.
			ControlerEventos.EventOff();
		}
	}
}
