﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody> ();
         rb.AddForce(new Vector3(0.3f,0,0),ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
