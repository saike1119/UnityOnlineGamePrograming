using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (tasisan (33, 5));
	}
	
	// Update is called once per frame
	void Update () {
	}

	//足し算をするメソッド
	public int tasisan(int x,int y){
		int z;
		z = x + y;
		return z;
	}
}
