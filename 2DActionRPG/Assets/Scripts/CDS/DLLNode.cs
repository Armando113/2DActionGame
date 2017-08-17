using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class DLLNode : MonoBehaviour
{
    //The Next node
    DLLNode pNext;
    //The Previous node
    DLLNode pPrev;

    //Big Four
    //Default Constructor
    public DLLNode()
    {

    }

    //Destructor
    ~DLLNode()
    {

    }

    //Gets and sets
    public DLLNode GetNext()
    {
        return pNext;
    }
    public void SetNext(DLLNode _next)
    {
        pNext = _next;
    }
    public DLLNode GetPrev()
    {
        return pPrev;
    }
    public void SetPrev(DLLNode _prev)
    {
        pPrev = _prev;
    }

    //Print info
    public virtual void PrintInfo()
    {
        //Do shit here
    }
}
