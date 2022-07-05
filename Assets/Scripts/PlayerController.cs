using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;

    private const float acceleration = 1;

    // Start is called before the first frame update
    private void Start()
    {
        speed = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        speed += acceleration * GetAccelerationInput();

        Move();
    }

    private void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private float GetAccelerationInput()
    {
        float accelerationInput = 0;

        // left shift to accelerate
        if (Input.GetKey(KeyCode.LeftShift))
        {
            accelerationInput += 1;
        }

        // left control to brake
        if (Input.GetKey(KeyCode.LeftControl))
        {
            accelerationInput -= 1;
        }

        return accelerationInput;
    }
}
