using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallHouse : House
{
    [Space(5)]
    [Header("Min & Max House Size")]
    [SerializeField]
    [Range(1, 30)]
    private float minS = 1;
    [SerializeField]
    [Range(1, 30)]
    private float maxS = 30;

    public override void Start()
    {

        SetHouseReference(); // Since we override the start we need to add this in again if its the wanted functionallity for our subclass else it wont do this.

        if(randStartSize) // Here we use the random spawn size method, we only want this feature in the tall house script & small house script so therefor we rather override the start instead of adding it into the house class by default 
        {
            RandomSpawnSize(new Vector3(), Random.Range(1, 5),Random.Range(5, 15), Random.Range(1, 3));

            houseX = rndSizeCached.x;
            houseY = rndSizeCached.y;
            houseZ = rndSizeCached.z;
        }

    }

    public override void Update() // Here we set the house size with a min and a max value. We also clamp it so we cannot go above or bellow this value.
    {
        SetHouseSize(ClampSize(new Vector3(), minS, maxS));
    }


}
