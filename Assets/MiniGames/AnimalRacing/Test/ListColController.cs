using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListColController : MonoBehaviour {

	public List<ColController> listCol;

	public ColController GetLastCol(){
		int index = 0;
		float maxX = listCol [index].transform.position.x;
		for (int i = 1; i < listCol.Count; i++) {
			if (listCol [i].transform.position.x > maxX) {
				index = i;
				maxX = listCol [i].transform.position.x;
			}
		}
		return listCol [index];
	}

	void Start(){
		StartCoroutine (DoActionUpdate ());
	}

	IEnumerator DoActionUpdate(){
		while(true){
			yield return null;
			//for (int i = 0; i < listCol.Count; i++) {
			//	Vector3 _pos = listCol [i].transform.position;
			//	_pos.x -= 4f * Time.deltaTime;
			//	listCol [i].transform.position = _pos;
		//	}
			for (int i = 0; i < listCol.Count; i++) {
				Vector3 _pos = listCol [i].transform.position;
				if (_pos.x + listCol [i].mySize.x/2 <= MyCameraController.instance.transform.position.x - MyCameraController.instance.sizeOfCamera.x/2) {
					ColController _lastCol = GetLastCol ();
					_pos.x = _lastCol.transform.position.x + _lastCol.mySize.x;
				}
				listCol [i].transform.position = _pos;
			}
		}
	}
}
