using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{

    /* Now when it comes to methods there's a load of information waiting for you however I will go over the most common ones you'll get the most use for at least in the start */

    /* NOTE: I will leave a source with some more information regarding the topic so if you want to come back later or check after you've completed this module then 
    you have some resources to check out and read up on :)*/


    /* Already when you create your very first script in C# you get introduced to the concept of methods. Every C# script will contain a start method as well as an update */


    // Start is called before the first frame update
    void Start()
    {
        /* Anything you put here will be called at game launch ONCE. */
    }

    // Update is called once per frame
    void Update()
    {
        /* Anything you put here will be done every frame, this is neat for updating movement for example but should be used with care. */
        /* Doing too much in update can eventually slow down your game, its adviced to disable scripts if they are no longer required to being called */
        /* If scripts are not to be called again you can even destroy the script itself (ONLY if the script wont be called anymore) */
    }

    /* Often overlooked yet extremely helpful is the OnEnable & OnDisable these will be called *EVERYTIME* the script is enabled or disabled */
    /* Unlike start which is just once on game starts */
    void OnEnable()
    {

    }

    void OnDisable()
    {

    }

    /* Void methods cannot return values and are commonly used across the board however we will be seeing how making methods with return type's / values can be beneficial */

    /* As promised its time to take a look at methods which return a value! Check out the script called return types in the same folder! */

    // Source BillWagner. (n.d.). Methods - C# programming guide. Developer tools, technical documentation and coding examples | Microsoft Docs. https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
    // Check out the source for more information on the matter.
}
