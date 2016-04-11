using UnityEngine;
using System.Collections;

public class RayCast : MonoBehaviour {

	public Transform obj;

	// Use this for initialization
		void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody> ();
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
			Camera.main.transform.LookAt (myRay.direction);
			Debug.DrawRay (myRay.origin, myRay.direction * 1000, Color.red);

		RaycastHit rayhit = new RaycastHit ();

		if (Physics.Raycast (myRay, out rayhit, 1000f) && Input.GetMouseButtonDown(0)){
			Debug.Log("You hit " + rayhit.transform);
			Instantiate(obj, rayhit.point, Random.rotation);
			Destroy (rayhit.collider.gameObject);
		}
	}
}
