using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Biggest change here will most likely be this:

public class TallHouse : House // We no longer derive from Monobehaviour, we instead derive from our parent script... Now what does this mean?

/* Well for starters we are now able to use method's, variables and even make changes to our parent from this script. */

{
    /* Since we created our house size variables as public we are able to change the size of this object using those sliders we are provided. */
    [Space(5)]
    [Header("Min & Max House Size")] // This is to make the script in the editor more easy to navigate.


    /* All which is left for us to do is to declare our max and min size for the house */
    [SerializeField]
    [Range(1, 30)]
    private float minS = 1;


    [SerializeField]
    [Range(1, 30)]
    private float maxS = 30;




    // Here we can see an example of how an override would go in a subclass:

    public override void Start()
    {

        SetHouseReference(); // Since we override the start we need to add this in again if its the wanted functionallity for our subclass else it wont do this anymore :).

        if(randStartSize) // Here we use the bool from our parent script to determine to use random size or not at the start.
        {
            /* 
            Here we use the random spawn size method, 
            we only want this feature in the tall house script & small house script so therefor we rather override the start instead of adding it into the house class by default
            
            Considering we use this in both small house and big house it would be resonable to have it in the original house script and rather override it it wasnt needed in our subclasses
            But hey... You get the point, this is for demonstration purposes. */ 

            RandomSpawnSize(new Vector3(), Random.Range(1, 5),Random.Range(5, 15), Random.Range(1, 3));

            /* We have to set our variables to match the new variables else we'll get janky behaviour if we were to change our House Size variables  */
            houseX = rndSizeCached.x;
            houseY = rndSizeCached.y;
            houseZ = rndSizeCached.z;
            /* Since this is only cast if we set to make a random spawn size, theres no need to do this outside of this if statement :) */
        }

    }

    


    public override void Update() // Here we set the house size with a min and a max value. We also clamp it so we cannot go above or bellow this value.
    {
        SetHouseSize(ClampSize(new Vector3(), minS, maxS));
    }


}