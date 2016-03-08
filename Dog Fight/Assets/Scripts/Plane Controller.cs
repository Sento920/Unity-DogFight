using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
    private Vector3 MousePos;
    public float PlaneSpeed;
    public float TurnSpeed;
    private float maxTurn;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {
        MousePos = Input.mousePosition;
	}

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(PlaneSpeed * Input.GetButton("Fire1"),0,0));
        rb.
    }
}
