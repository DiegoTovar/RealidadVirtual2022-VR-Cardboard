using UnityEngine;
using System.Collections;

public class FPSCounter : MonoBehaviour
{
	private float deltaTime = 0.0f;

	void Update()
	{
		//se calcula el tiempo por frame
		deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
	}

	//Se muestra el frame rate en pantalla
	void OnGUI()
	{
		int w = Screen.width, h = Screen.height;

		GUIStyle style = new GUIStyle();

		Rect rect = new Rect(0, 0, w, h * 2 / 100);
		style.alignment = TextAnchor.UpperLeft;
		style.fontSize = h * 2 / 100;
		style.normal.textColor = new Color (0.0f, 0.0f, 0.5f, 1.0f);
		string text = string.Format("{0:0} FPS", 1.0f / deltaTime);
		GUI.Label(rect, text, style);
	}


}