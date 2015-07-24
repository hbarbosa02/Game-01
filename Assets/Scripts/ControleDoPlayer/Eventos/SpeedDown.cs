/*
 * Classe Contreta para executa a coroutina de Diminuir da velocidade do escudo.
 */
using UnityEngine;
using System.Collections;

public class SpeedDown : ControlerEventos {

	public float _speedDown;
	internal override void Update()
	{
		base.Update ();
		StartCoroutine(SpeedDOWN(ControlerEventos.EventStart, ControlerEventos.RandomVelor, _speedDown));
	}
	IEnumerator SpeedDOWN(bool StateEvent, int Valor, float SpeedDown)
	{
		if(StateEvent == true && Valor == 1 && ControlerEventos.EventAtivo == false)
		{
			//Afirmando que tem um evento em açao nesse moemnto
			ControlerEventos.EventAtivo = true;
			//Evento em açao.
			float InitSpeed = BasePlayer.Speed;
			BasePlayer.Speed -= SpeedDown;
			yield return new WaitForSeconds(5);//Duraçao do evento.
			BasePlayer.Speed = InitSpeed;
			//Desativando o Evento.
			ControlerEventos.EventOff();
		}
	}
}
