using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class DLL
{
    //The active head
    protected DLLNode pActiveHead;
    //The Reserve Head
    protected DLLNode pReserveHead;

    //Big Four
    //Default constructor
    public DLL()
    {

    }
    //Destructor
    ~DLL()
    {

    }

    /*-----Internal Functions-----*/

    //Pop a node from Reserve Stack
    protected DLLNode PopReserve()
    {
        //if out list is null, return null
        if (pReserveHead == null)
        {
            return null;
        }

        DLLNode pResult = pReserveHead;

        //Case 1: It's the last node
        if (pReserveHead.GetNext() == null)
        {
            //The head is now null
            pReserveHead = null;
        }
        //Case 2: we have more nodes in the list
        else
        {
            //Move the reserve head to the next node
            pReserveHead = pResult.GetNext();
            //Unlink the reserve from the result node
            pReserveHead.SetPrev(null);
            //Unlink the node from head
            pResult.SetNext(null);
        }

        //Return the result
        return pResult;
    }
    //Push a node to reserve
    protected void PushReserve(DLLNode _node)
    {
        //Check for null pointer
        if (_node == null)
        {
            return;
        }

        //case 1: the stack is empty
        if (pReserveHead == null)
        {
            //the head is now the node
            pReserveHead = _node;
        }
        //Case 2: The stack is not empty
        else
        {
            //Link the node to the head
            _node.SetNext(pReserveHead);
            //Link the head to the node
            pReserveHead.SetPrev(_node);
            //Move the head to the node
            pReserveHead = _node;
        }
    }
    //Add a node to the active list
    protected DLLNode AddActive(DLLNode _node)
    {
        //Check for null
        if (_node == null)
        {
            return null;
        }
        //Case 1: List is empty
        if (pActiveHead == null)
        {
            //Head is now the node
            pActiveHead = _node;
        }
        //Case 2: There are nodes in the list
        else
        {
            //Link the node to the head
            _node.SetNext(pActiveHead);
            //Link the head to the node
            pActiveHead.SetPrev(_node);
            //Move the head to the node
            pActiveHead = _node;
        }

        return _node;
    }
    //Remove a node from the Active list
    protected DLLNode RemoveActive(DLLNode _node)
    {
        //check for a null node
        if (_node == null)
        {
            return null;
        }

        //Case 1: the node is the last one in the list
        if (pActiveHead == _node && _node.GetNext() == null)
        {
            //The head is now null
            pActiveHead = null;
        }
        //Case 2: The node is the head, but there are more nodes in the list
        else if (pActiveHead == _node)
        {
            //Move the head to th next node
            pActiveHead = _node.GetNext();
            //unlink the node 
            _node.SetNext(null);
            //Unlink head
            pActiveHead.SetPrev(null);
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

        return _node;
    }
    //Find a node in the active list
    protected DLLNode FindActive(DLLNode _node)
    {
        //Set the iterator
        DLLNode pIt = pActiveHead;

        while (pIt != null)
        {
            //did we find it?
            if (pIt == _node)
            {
                return pIt;
            }
            //Keep walking Johnny
            pIt = pIt.GetNext();
        }

        return null;
    }

    //Get the size of the active list
    public int GetSize()
    {
        int count = 0;
        //Set the iterator
        DLLNode pIt = pActiveHead;

        while (pIt != null)
        {
            count += 1;
            //Keep walking Johnny
            pIt = pIt.GetNext();
        }

        return count;
    }
    //Print the info of the nodes
    public void PrintNodes()
    {
        //Set the iterator
        DLLNode pIt = pActiveHead;

        while (pIt != null)
        {
            //Print info
            pIt.PrintInfo();
            //Keep walking Johnny
            pIt = pIt.GetNext();
        }
    }
}
