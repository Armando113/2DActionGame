using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInputCtrl : MonoBehaviour
{
    //The Player object
    [SerializeField]
    private TestPlayer pPlayer;

	// Use this for initialization
	void Start ()
    {
        Debug.Assert(pPlayer != null);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.W))
        {
            //Jump
            //pPlayer.Jump(150.0f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            //Duck(?)
        }
        if(Input.GetKey(KeyCode.D))
        {
            //Go right
            pPlayer.MoveSide(5.0f * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            //Go Left
            pPlayer.MoveSide(-5.0f * Time.deltaTime);
        }
        else
        {
            pPlayer.MoveSide(0.0f);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {

        }

        //Up keys
        //if (Input.GetKeyUp(KeyCode.D))
        //{
        //    //Go right
        //    pPlayer.MoveSide(0.0f);
        //}
        //else if (Input.GetKeyUp(KeyCode.A))
        //{
        //    //Go Left
        //    pPlayer.MoveSide(0.0f);
        //}
    }
}
