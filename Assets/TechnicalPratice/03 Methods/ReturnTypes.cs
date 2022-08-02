using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTypes : MonoBehaviour
{

    /* As promised we will now be taking a look at how we can use methods with return types! */

    /* I'll break down a script I just wrote as i use 3 different types of methods in this one to control what level the player is and their paragon level */

    /* This was inspired by the system Diablo 3 works with essentially. Our goal is to create a script with a min and max level, but we want our player to still wish to grind
       We do this by encurraging the player to get paragon levels on top of the normal levels. The dopamine rush helps retian the player too. */

    /* 
        As you can see i've also dressed the code up a tiny bit by adding Headers and Spaces for the time being you can ignore them.
        I will be going in depth on the topic in the Code Readability Section!
        
    */
    [Header("Player Information")]
    [Space(15)]
    [SerializeField]

    /* I also keep variables private, the reason why I do this is in the event I were to create a child script from this there will be less confusion as they wont show up */
    /* But as you can see i still want the values to show in the editor. Thats where [SeralizeField] comes in. More on this topic much later but do know it exists */
    
    private string playerName = "CoolGuy47";
    private string playerIntroduction = "Your Player Name is ";
    private string playerLevel = " And you are Level ";
    private string playerInformation = "Something";

    [Header("Max Level, Exp & Paragon Stats")]
    [Space(10)]
    [SerializeField]
    private int exp = 0;

    [SerializeField]
    private int maxLevel = 10;

    [SerializeField]
    private int paragonExp = 0;

    [SerializeField]
    private int maxParagon = 20;

    [Header("Required Exp Values")]
    [Space(10)]
    [SerializeField]
    [Range(0,1500)]
    private int requiredExpForLevel = 50;

    [Space]
    [SerializeField]
    [Range(0,1500)]
    private int requiredExpForParagon = 20;

    private int minLevel = 0; // Just declaring the minimum level so the player cant go in minus. Yes technically we could just write 0
    /* But when writing code its usually better to have a variable tied to the number for various of reasons */
    /* Scaleability to mention 1 reason, values can always be changed and edited. This gives flexibility to create new modes or test new values*/
    private int cLevel = 0;
    private int pLevel = 0;

    // Start is called before the first frame update
    void Update()
    {
        /* Naturally you want to avoid casting things like this every frame in update however, since im just trying to quickly display what this script does
           and how we can use differnt methods to our advantage */
           UpdateString(playerInformation);

        /* This is essentially just a temporary fix as this level system might be something you'd want to keep on for the entire game. Here i just turn off the script
            limiting the use of Update(). Do note there are many ways to avoid update or clear update but this is an example of 1 at least */
        if(UpdateParagonLevel == maxParagon)
        {
            this.enabled = false;
        }

    }

    /* Here we say that this method will return a string value */
    private string UpdateString(string value)
    {

        if(UpdateCurrentLevel < maxLevel)
        {
            paragonExp = 0;
            value = playerIntroduction + playerName + playerLevel + Mathf.Clamp(UpdateCurrentLevel, minLevel, maxLevel);
        }
        else
        {
            exp = maxLevel * requiredExpForLevel;
            value = playerIntroduction + playerName + playerLevel + Mathf.Clamp(UpdateCurrentLevel, minLevel, maxLevel) + StringForParagon + Mathf.Clamp(UpdateParagonLevel, minLevel, maxParagon);
       }

        if(cLevel != UpdateCurrentLevel)
        {
            Debug.Log(value);
            cLevel = UpdateCurrentLevel;
        }

        else if (pLevel != UpdateParagonLevel)
        {
            Debug.Log(value);
            pLevel = UpdateParagonLevel;
        }

        return value;
    }

    private int UpdateCurrentLevel
    {
        get { return (exp / requiredExpForLevel); }
    }

    private string StringForParagon
    {
        get { return(" Your Paragon Level Is "); }
    }

    private int UpdateParagonLevel
    {
        get {return (paragonExp / requiredExpForParagon); }
    }

}
