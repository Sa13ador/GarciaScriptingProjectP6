using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunction : MonoBehaviour
{
    // Start is called before the first frame update
    //create an intger variable
    public int myInt = 5;
    private int number;

    void Start()
    {
        //run the variable through my function
        myInt = MultiplyByTwo(myInt);

        //display the result in the console
        Debug.Log(myInt);
    }

    private int MultiplyByTwo(int myInt)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    int Update()
    {
        //create a results variable
        int results;
        results = number * 2;

        //return the result
        return results;
    }
}
