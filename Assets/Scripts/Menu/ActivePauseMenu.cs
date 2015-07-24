using UnityEngine;
using System.Collections;

public class ActivePauseMenu : MonoBehaviour {

	public GameObject MenuDePausa;
	void Update () {
	
	}
	void Active()
	{
		if(Input.GetKey(KeyCode.A))
		{
			MenuDePausa.SetActive(true);
		}
	}
}
