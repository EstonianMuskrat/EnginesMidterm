using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class BNFMovement : MonoBehaviour
{
    public float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(0.678744316f, 11.9928875f, -13.2008953f);
    }

    // Update is called once per frame
    void Update()
    {
        //move wall from initial position 2 units to the right, then 4 units to the left, then 4 to the right, ...
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, 4),
            transform.position.y, transform.position.z);
    }
}
