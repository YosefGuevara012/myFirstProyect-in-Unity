using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Variables

    public float moveSpeed = 5f;
    public float rotateSpeed = 60f;

    private float hInput, vInput;

    private Rigidbody _rb;

    // Methods

    // Start is called before the first frame update
    void Start()
    {

        _rb = GetComponent<Rigidbody>();
        moveSpeed = 5;
        rotateSpeed = 15;

    }

    // Update is called once per frame
    void Update()
    {

        // How much is going to move (Hardware Speed)
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        vInput = Input.GetAxis("Vertical") * moveSpeed;

        // Movement Vector (Phisical Speed)
        // Forma de mover al jugador sin usar el motor fisicas
        //this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        //this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        // so = S0 + v*t

        _rb.MovePosition(this.transform.position +
                         this.transform.forward * vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot); 

    
    }

}
