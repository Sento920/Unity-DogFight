using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
    private Transform MousePos;
    public float PlaneSpeed;
    public float TurnSpeed;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
