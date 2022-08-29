using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

	private Renderer render;
	private Texture auxTex;
	private Color auxColor;
	public Texture cambioTex;
	public Color cambioColor;
	public float giro=10f;

	void Start() {
		//inicializamos el renderer donde se guarda el material
		render = GetComponent<Renderer>();
		//guardamos el color y textura actuales antes de hacer cambios
		auxTex = render.material.GetTexture ("_MainTex");
		auxColor = render.material.GetColor ("_Color");
	}

	void FixedUpdate(){
		//se hace rotar el objeto en el eje Y global a la velocidad indicada en "giro"
		transform.Rotate (Vector3.up * Time.deltaTime * giro, Space.World);
	}

	public void Cambiar(bool visto) {
		if (visto) {
			//cambiamos coor y textura por los parametros indicados en el inspector
			render.material.SetTexture ("_MainTex", cambioTex);
			render.material.SetColor ("_Color", cambioColor);
		} else {
			//colocamos color y textura original
			render.material.SetTexture ("_MainTex", auxTex);
			render.material.SetColor ("_Color", auxColor);
		}
	}
}
