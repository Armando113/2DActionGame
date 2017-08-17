using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GamePawn : GameActor
{
    ///---Variables
    //The rigidbody (yes, all pawns must have Rigidbody2D)
    protected Rigidbody2D pRigidbody;
    //The velocity of our character
    protected Vector3 vVelocity;
    //The current speed
    protected float fSpeed;
    //The jump force
    protected float fJumpForce;
    //Are we in the ground?
    protected bool bFloored;
    //The type of pawn
    protected PawnType kPawnType;
    //The health of the pawn
    protected int health;

    //Constructor
    protected GamePawn(PawnType _pawnType) : base(ActorType.PAWN)
    {
        this.kPawnType = _pawnType;
    }

    //The rigidbody function
    protected override void Initialize()
    {
        //Simple get rigidbody
        pRigidbody = this.GetComponent<Rigidbody2D>();
    }

    //Get the type of pawn type
    public PawnType GetPawnType()
    {
        return kPawnType;
    }

    ///---Basic Motor functions
    //Move the pawn 
    //Vector 3 version
    protected virtual void Move()
    {
        //X Speed
        this.vVelocity.x = this.fSpeed;
        //Y Speed
        this.vVelocity.y = this.fJumpForce;
        //Do a basic movement for now
        this.transform.position += this.vVelocity;
    }
    //Calculate the y force
    protected virtual void CalculateYForce()
    {
        //Check if 
    }
    
    //Move to the side
    public virtual void MoveSide(float _speed)
    {
        //set the x speed
        this.fSpeed = _speed;
    }

    //Jump mechanic
    public virtual void Jump(float _force)
    {
        if(bFloored)
        {
            //Add force to the object
            this.fJumpForce = _force;
        }
    }

    ///-----Collision Functions
    //On Collision enter
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit me ._.");
        //We have touched the floor
        bFloored = true;
    }

    //On Collision Stay
    public void OnCollisionStay2D(Collision2D collision)
    {
        //We are still floored
        bFloored = true;
    }

    //On Collision Exit
    public void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("bye now ._.");
        //We are no longer floored
        bFloored = false;
    }
}
