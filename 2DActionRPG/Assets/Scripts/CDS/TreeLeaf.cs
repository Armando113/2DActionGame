using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeLeaf : TreeComponent
{

    //Constructor
    protected TreeLeaf()
    {

    }
    
    ///---Internal functions
    protected override TreeComponent AddActiveChild(TreeComponent _node)
    {
        //Do Jack shit
        return null;
    }
    protected override TreeComponent PopReserve()
    {
        //Do Jack shit
        return null;
    }
    protected override TreeComponent PushReserve(TreeComponent _node)
    {
        //Do jack shit
        return null;
    }
    protected override TreeComponent RemoveActiveChild(TreeComponent _node)
    {
        //Do jack shit
        return null;
    }
}
