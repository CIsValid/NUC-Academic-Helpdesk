using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Check out TallHouse Script first */

// Like i mentioned in Tallhouse.cs we now derive from our parent script instead of Monobehaviour!
public class SmallHouse : House
{


    [Space(5)]
    [Header("Min & Max House Size")]

    /* Here we can see how we can limit a designer from making the size exceed that of the tall house */
    [SerializeField]
    [Range(-10, 10)] // The limitations are pretty much being put here :)
    private float minS = -10;


    [SerializeField]
    [Range(-10, 10)] // And here! :D
    private float maxS = 10;

    public override void Start()
    {

        SetHouseReference(); // We do this why? Correct, since we are overriding the start function!

        if(randStartSize)
        {
            // Key difference here is that we change the random range values to be much smaller then the tall house.
            RandomSpawnSize(new Vector3(), Random.Range(1, 2),Random.Range(1, 6), Random.Range(1, 2));

            // Like mentioend we need to set our variables to match the random sizes we just got :thumbs-up:
            houseX = rndSizeCached.x;
            houseY = rndSizeCached.y;
            houseZ = rndSizeCached.z;
        }

    }

    // Just like in TallHouse.cs we override the update and use a mixture of our SetHouseSize & ClampSize methods to elegantly set our house size to match but also clamp its values :)
    public override void Update()
    {
        SetHouseSize(ClampSize(new Vector3(), minS, maxS));
    }

    // Making versions like this we can already see how much easier it is for the designers to use our code and create the level as things do exactly as the name suggests
    // TallHouse Makes a tall house & small house makes a small house. The small house can never exceed that of the tall house since then it would no longer correspond to its name!

}

