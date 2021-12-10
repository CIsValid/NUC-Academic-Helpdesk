using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamingConventions : MonoBehaviour
{
    /* Something people dont usually think of when it comes to programming is that how you write variables and methods actually matter */

    /* When programming its very common to use cammel Case for variables meaning it should look like this:  */

    [SerializeField]
    private int variableName = 2;


    /* And for methods we use Pascal Case as you can see here */
    private void ThisFunctionIsAwesome()
    {
        Debug.Log("It is very important to use camel Case for variables and Pascal Case for Methods");
    }

    /* To finish off this module i'd also like to stress the importance of not having spaces in your variable names and method names */

    
}
