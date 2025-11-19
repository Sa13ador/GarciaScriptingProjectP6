using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int cupsInTheSink = 4;
       while (cupsInTheSink >  0)
        {
            Debug.Log("I've washed a cup!"):
                cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
