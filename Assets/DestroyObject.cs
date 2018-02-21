using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

//Lesson6課題：不可視化状態に読み込められる
	private GameObject unityChan;

	private float  odj;            //オブジェクト用変数作成
//Lesson6課題：不可視化状態に読み込められる

	// Use this for initialization
	void Start () {

//Lesson6課題：不可視化状態に読み込められる
		unityChan = GameObject.Find("unitychan");

		odj = this.transform.position.z + 10;　　//アタッチしたオブジェクトのｚ+10を座標取得（通り過ぎてすぐ消えない様に+10）
//Lesson6課題：不可視化状態に読み込められる
	}
	
	// Update is called once per frame
	void Update () {


//Lesson6課題：不可視化状態に読み込められる
		if (odj < unityChan.transform.position.z) {　　　//unityChanがこのオブジェクトを通過したら動作
			Destroy(this.gameObject);
		}
//Lesson6課題：不可視化状態に読み込められる

	}

	//Lesson6課題：不可視化状態に読み込められる-再提出のため不採用(シーン全体表示だと消えないため)
//	public void OnBecameInvisible(){
//		Destroy(this.gameObject);
//	}

}
