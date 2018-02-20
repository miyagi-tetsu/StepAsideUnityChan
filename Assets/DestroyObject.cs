using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Lesson6課題：不可視化状態に読み込められる
	public void OnBecameInvisible(){
		Destroy(this.gameObject);

	}

}
