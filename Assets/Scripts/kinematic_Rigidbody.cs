using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kinematic_Rigidbody : MonoBehaviour
{
    //public void MovePosition(Vector3 position);
    [SerializeField] private bool isCharacterGrounded = false;
    public float groundDistance;
    public LayerMask GroundLayer;
    private Vector3 velocity = Vector3.zero;

    Rigidbody m_Rigidbody;
    public float m_Speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            m_Rigidbody.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            m_Rigidbody.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.W))
            m_Rigidbody.AddForce(Vector3.up);
        if (Input.GetKey(KeyCode.S))
            m_Rigidbody.AddForce(Vector3.down);
        //check if character is on ground
        isCharacterGrounded = Physics.CheckSphere(transform.position, groundDistance, GroundLayer);
      
    }

    void FixedUpdate()
    {
        //Store user input as a movement vector
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);

        
    }
}

