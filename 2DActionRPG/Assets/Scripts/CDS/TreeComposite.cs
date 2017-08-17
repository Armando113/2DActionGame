using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeComposite : TreeComponent
{
	//Constructor
    protected TreeComposite()
    {

    }

    ///---Internal methods
    //Add to reserve
    protected override TreeComponent PushReserve(TreeComponent _node)
    {
        //Check for null
        Debug.Assert(_node != null);
        //Case 1: list is empty
        if(this.pChildReserve == null)
        {
            //head is now node
            this.pChildReserve = _node;
        }
        //Case 2: list is not empty
        else
        {
            //Link node to head
            _node.SetNext(this.pChildReserve);
            //Link head to node
            this.pChildReserve.SetPrev(_node);
            //set head
            this.pChildReserve = _node;
        }
        //return node
        return _node;
    }
    //Pop reserve
    protected override TreeComponent PopReserve()
    {
        //Is it null?
        if (pChildReserve == null)
        {
            return null;
        }
        //Get the head
        TreeComponent result = this.pChildReserve;
        //Case 1: Last node in the list
        if(result.GetNext() == null)
        {
            //Head is now null
            this.pChildReserve = null;
        }
        //Case 2: There are more nodes
        else
        {
            //Move 
            this.pChildReserve = result.GetNext();
            //Detach node
            result.SetNext(null);
            //Detach head
            this.pChildReserve.SetPrev(null);
        }
        //Return result
        return result;
    }
    //Add child
    protected override TreeComponent AddActiveChild(TreeComponent _node)
    {
        //Make sure it isn't null
        Debug.Assert(_node != null);
        //Case 1: the list
        if(pChildActive == null)
        {
            //Head is now the node
            pChildActive = _node;
        }
        //Case 2: there are more nodes
        else
        {
            //Link the node to the head
            _node.SetNext(pChildActive);
            //Link the head to the node
            pChildActive.SetPrev(_node);
            //Move the head to the node
            pChildActive = _node;
        }
        //return node
        return _node;
    }
    //Remove Child
    protected override TreeComponent RemoveActiveChild(TreeComponent _node)
    {
        //Make sure it isn't null
        Debug.Assert(_node != null);

        //Case 1: the node is the last one in the list
        if (pChildActive == _node && _node.GetNext() == null)
        {
            //The head is now null
            pChildActive = null;
        }
        //Case 2: The node is the head, but there are more nodes in the list
        else if (pChildActive == _node)
        {
            //Move the head to th next node
            pChildActive = _node.GetNext();
            //unlink the node 
            _node.SetNext(null);
            //Unlink head
            pChildActive.SetPrev(null);
        }
        //Case 3: The node is lost somewhere in the list (including at the very end!)
        else
        {
            //Link it's next to the prev (If available)
            if (_node.GetNext() != null)
            {
                _node.GetNext().SetPrev(_node.GetPrev());
            }
            //Link the Previous to the next
            if (_node.GetPrev() != null)
            {
                _node.GetPrev().SetNext(_node.GetNext());
            }

            //Completely Unlink the node
            _node.SetNext(null);
            _node.SetPrev(null);
        }

        //Return node
        return _node;
    }
}
