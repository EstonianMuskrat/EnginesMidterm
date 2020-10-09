using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 initialPos;
    public float speed;
    public int maxYPos = -5;
    //public bool Ending == false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPos = transform.position;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void Update()
    {
        if (gameObject.transform.position.y < maxYPos)
        {
            transform.position = initialPos;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == ("Goal"))
        {
            SceneManager.LoadScene("End Scene");
            //Ending == true;
        }
    }
}