using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonFix : MonoBehaviour {
	void Awake() {
		//activamos el boton volver del dispositivo movil para salir de la aplicacion
		Input.backButtonLeavesApp = true;
	}
		
	void Update () {
		//salir de la aplicacion cuando presionamos el boton X de la interfaz de Google VR
		if (Input.GetKeyUp(KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
