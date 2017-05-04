using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour
{

    public GameObject ballPreFab;

    // Use this for initialization
    void Start()
    {
        //print(ballPreFab);

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5.0f;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject instance = Instantiate(ballPreFab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject instance = Instantiate(ballPreFab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * speed;
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(ballPreFab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject instance = Instantiate(ballPreFab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.back * speed;
        }
    }
}
