using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 20;
    [SerializeField]
    private float turnSpeed = 5;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.horizontalInput = Input.GetAxis("Horizontal");
        this.forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * this.speed * this.forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * this.turnSpeed * this.horizontalInput);
    }
}
