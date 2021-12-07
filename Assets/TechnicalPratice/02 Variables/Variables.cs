using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

    /* Q: What is a Variable?

    
    "Variable:
    In a program, data values can be constant or variable. If values are variable they can be changed by the program and the user.
    When a program is run, the data values are held in memory whilst they are being worked on".

    Constant Variable:
    "Data values that stay the same every time a program is executed are known as constants. Constants are not expected to change."


    Source: Programs and data - Constants, variables and data types - GCSE Computer Science Revision. (n.d.). BBC Bitesize. Retrieved December 7, 2021, from https://www.bbc.co.uk/bitesize/guides/zc6s4wx/revision/1


    */


    /* Variable types can come in many forms */

    public float speed;
    private float speedPrivate;
    private const float constSpeed = 2;
    public GameObject player;
    private Camera playerCamera;

    /* To name a few, but do not fear. This is something you will remember overtime and in the case you dont... well then you reference to the Unity Documentation :D

        IMPORTANT: It is never wrong to look at the Unity Documentation, Stackoverflow. You should look at it like a reference image for art.
     */

    /* What does it mean to declare a variable?
    
        Declaring a variable is to give it a value before it gets called in a function.

        An example of declaring a variable would be:

        public float speed = 2.2f; // Now we know if we use the variable anywhere and it hasn't been changed it will give us 2.2.

    */

    /* Now if any of these above here confuses you dont fear cause ill be explaing the use case and what we are refering to shortly */

    /* For any future variable mentions I will also make sure to Declare the value as it prevents NULL Reference errors / other mistakes more on this later.
    Its also wise to do this from the start since you'll get used to it, which will be making it easier to jump to other languages that needs it. Eherm.. Looking at you C++ >:( */ 

    /* Floats are decimal numbers */

    public float AttackSpeed = 2.2f; // We will now call this in the Start function once to see the output. Proceed to press play :)


    /* Now its time to cover some of the Variables and what they are used for! */


    /* Now it's time for a couple of small assignments!     */

    /* A. Create you own Variable remember to set its value */
    /* Start of assignment A Enter Your Answer Bellow */




    /* End of assignment A */

    /*B. */
    /* Start of assignment B Enter Your Answer Bellow */



    /* End of assignment B */

    /*C. Scroll down until you see "private void UserVariableTest()" */

    /* Now as you can see we can also write text in the script,
    but in order for the editor to igore whats being written we need to start with either // or we cover the text like so /* Your text here */


    // Start is called before the first frame update
    void Start()
    {
        VariableShowcase();
        UserVariableTest();
    }


    private void VariableShowcase()
    {
        Debug.Log(AttackSpeed);
    }

    private void UserVariableTest()
    {

    /* C. You should now already have created a variable, use the above function as a hint as to how to display your variable*/
    /*Start of assignment C Enter Your Answer Bellow */



    /* End of assignment C */

    }
}
