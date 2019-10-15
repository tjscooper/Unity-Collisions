using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create a parameter available in the Unity IDE
    public float speed = 10.0f;
    // Store the Player movement velocity
    Vector3 velocity;

    // Create a variable to store the reference to the Game Object Component "Rigidbody"
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the Rigidbody Component when the Player is loaded
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get Input from the Keyboard
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        // Determine the direction by reducing the input values to a range [0..1]
        Vector3 direction = input.normalized;
        // Add speed to the direction to determine the velocity
        velocity = direction * speed;
    }

    private void FixedUpdate()
    {
        rb.position += velocity * Time.fixedDeltaTime;
    }
}
