using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetu1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数5の配列を初期化する
		int[] arrays = new int[5];

		// 配列の各要素に値を代入する
		arrays [0] = 100;
		arrays [1] = 300;
		arrays [2] = 500;
		arrays [3] = 700;
		arrays [4] = 900;

		// 配列の要素をすべて表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (arrays [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
