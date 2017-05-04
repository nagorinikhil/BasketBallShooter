using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

    public GameObject ballPreFab;
    public float ballSpeed = 5.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(ballPreFab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * ballSpeed;
        }
    }
}
