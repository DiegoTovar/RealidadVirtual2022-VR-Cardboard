using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	public GameObject cubo;
	void LateUpdate(){
		//sigue la rotacion en el eje Y del objeto cubo
		transform.localRotation = Quaternion.Euler(-90,cubo.transform.eulerAngles.y,45);
	}


}
