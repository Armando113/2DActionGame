using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeComponent : MonoBehaviour
{
    ///----Variables
    //The Active Head 
    protected TreeComponent pChildActive;
    //The Reserve head
    protected TreeComponent pChildReserve;
    //The Next link
    protected TreeComponent pNext;
    //The Prev link
    protected TreeComponent pPrev;

    //Constructor
    protected TreeComponent()
    {

    }

    ///---Get Sets
    //Set Next
    public void SetNext(TreeComponent _next)
    {
        this.pNext = _next;
    }
    //Get the next 
    public TreeComponent GetNext()
    {
        return pNext;
    }
    //Set Prev 
    public void SetPrev(TreeComponent _prev)
    {
        this.pPrev = _prev;
    }
    //Get the previous
    public TreeComponent GetPrev()
    {
        return pPrev;
    }

    ///---Internal Methods
    //Push to reserve
    protected abstract TreeComponent PushReserve(TreeComponent _node);
    //Add to reserve
    protected abstract TreeComponent PopReserve();
    //Add a Child to Active
    protected abstract TreeComponent AddActiveChild(TreeComponent _node);
    //Remove an active child
    protected abstract TreeComponent RemoveActiveChild(TreeComponent _node);

}
