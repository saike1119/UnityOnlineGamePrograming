using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Example : MonoBehaviour {

	public float rnd;

	// Use this for initialization
	void Start () {
		rnd = Random.value;
		Debug.Log (rnd);
		Debug.Log (tasisan (33, 5));
		Debug.Log (hikisan (100, 64));

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

	//引き算をするメソッド
	public int hikisan(int x,int y){
		int z;
		z = x - y;
		return z;
	}
}
