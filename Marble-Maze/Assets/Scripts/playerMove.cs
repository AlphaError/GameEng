using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
	int playerSpeed = 10;
	Rigidbody _rigidBody;

    // Start is called before the first frame update
    private void Start()
    {
    	_rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float zSpeed = Input.GetAxis("Vertical") * playerSpeed;
        float xSpeed = Input.GetAxis("Horizontal") * playerSpeed;
        float ySpeed = 0f;

        Vector3 add_vec = new Vector3(xSpeed, ySpeed, zSpeed);
        _rigidBody.AddForce(add_vec);
        Debug.Log("Added Vector:" + add_vec);

        // if over time limit:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        // Note: maybe skrink the player scaling with time --> coroutine time.time?
        // transform.scale *= 1/time.time;
        // transform.rotation (forces  = addTorque)
    }
}
