using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameActor : TreeLeaf
{
    ///---Variables
    //The 2D Collider
    private Collider2D pCollider;
    //Custom sprite class
    //The type of actor
    protected ActorType kActorType;

    //constructor
    protected GameActor(ActorType _type)
    {
        kActorType = _type;
    }
	
    //Get type
    public ActorType GetActorType()
    {
        return kActorType;
    }

    //Initialize function
    protected virtual void Initialize()
    {
        //Do nothing for now
    }
}
