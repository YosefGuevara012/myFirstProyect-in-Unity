using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    // Variables

    public float moveSpeed = 5f;
    public float rotateSpeed = 5f;
    public float jumpSpeed = 5f;

    public float currentMoveSpeed;
    public float currentRotateSpeed;

    private float hInput, vInput;
    
    // Usually _ is used to name a private component of an object
    private Rigidbody _rb;

    // JumpVariables

    public float distanceToGround = 0.1f;
    public LayerMask groundLayer;
    private CapsuleCollider _col;

    // Methods

    // Start is called before the first frame update
    void Start()
    {

        _rb = GetComponent<Rigidbody>();
        currentMoveSpeed = moveSpeed;
        currentRotateSpeed = rotateSpeed;

        _col = GetComponent<CapsuleCollider>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Fire1") > 0.5)
        {
            currentMoveSpeed = moveSpeed / 2.0f;
            currentRotateSpeed = rotateSpeed / 2.0f;

        }
        else
        {

            currentMoveSpeed = moveSpeed;
            currentRotateSpeed = rotateSpeed;

        }
       

        // How much is going to move (Hardware Speed)
        hInput = Input.GetAxis("Horizontal") * currentRotateSpeed;
        vInput = Input.GetAxis("Vertical") * currentMoveSpeed;

        // Movement Vector (Phisical Speed)
        // Forma de mover al jugador sin usar el motor fisicas
        //this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
        //this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);

        if (IsOnTheGround() && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }

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

    bool IsOnTheGround()
    {

        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x,
                                            _col.bounds.min.y,
                                            _col.bounds.center.z);

        bool onTheGround = Physics.CheckCapsule(_col.bounds.center,
                                                capsuleBottom,
                                                distanceToGround,
                                                groundLayer,
                                                QueryTriggerInteraction.Ignore);
        return onTheGround;



    }

}
