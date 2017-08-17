using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : PlayerBase
{

	// Use this for initialization
	void Start ()
    {
        this.Initialize();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Set speed to 0
        //this.fSpeed = 0.0f;
	}

    private void FixedUpdate()
    {
        this.Move();
    }
}
