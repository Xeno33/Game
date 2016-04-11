using UnityEngine;
using System.Collections;

public class AmmoPrefab : MonoBehaviour {

	public Rigidbody kitten;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
		{
			Instantiate(kitten);
		}
	
	}
}
