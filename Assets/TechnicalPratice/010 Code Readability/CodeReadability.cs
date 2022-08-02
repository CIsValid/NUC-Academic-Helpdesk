using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeReadability : MonoBehaviour
{

    /* This Section is to improve code readability */
    /* 
        It is a very common occurance for code to become hard to navigate after a certain point.
        There are a few ways we can prevent code from going down this route. One of which we've already talked about which is Naming Conventions. 
        But we can take it a step even further, how? That is by utilizing Header Attributes.
    */

    /* Lets first take a look at some Header Attributes we can use!  */

    [Header("Player Introduction")] // Creates a title for the section.
    public string playerName = "myString";
    [TextArea(minLines: 3, maxLines: 6)]                 // Convenient for when you wish to set a spessific number of max lines
    public string playerDescription = "myDescription";
    [Multiline]                                         // Pretty much the same as the TextArea, however it allows us to overflow the text area as we please.
    public string playerSecondDescription = "mySecondDescription";

    [Header("Player Stats")] // Creates a title for the section.
    [Range(-0.7f, 0.7f)]                               // Gives the option of using a slider to set the value plus limit the min & max value of the variable.
    public float blockChance = 0.0f;
    [Range(0, 100)]                                    // This works also for int values :)
    public int level = 0;

    [Header("Enemy Detection")]                         // Creates a title for the section.
    [Tooltip("The current target of our player")]      // Creates a tool tip for the variable when being hovered over
    public GameObject target = null;
    [Space]                                          // Gives a small "Space" in the editor to the Variable above.
    public Vector3 enemyLocation = new Vector3(0,0,0);

    /* ---------------------------------------------------------------  */

    /* To read further on the topic check out:
    Technologies, U. (n.d.). Unity - Scripting API: HeaderAttribute. Unity Documentation. https://docs.unity3d.com/ScriptReference/HeaderAttribute.html
    Weimann, J. (2017, May 23). Improving the Unity Editor Inspector with Unity Attributes. Unity3D.College. https://unity3d.college/2017/05/22/unity-attributes/
    E. (2021, March 7). 7 Useful Unity Attributes That Make the Inspector Easier To Use. Medium. https://medium.com/star-gazers/4-useful-unity-attributes-that-make-the-inspector-easier-to-use-part-1-d42b5b0b7543 */
}
