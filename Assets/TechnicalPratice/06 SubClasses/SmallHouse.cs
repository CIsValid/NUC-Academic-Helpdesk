using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallHouse : House
{

    [Space]
    [Header("Checks")]
    [SerializeField]
    private bool randStartSize = false;

    public override void Start()
    {

        SetHouseReference();

        if(randStartSize)
        {
            RandomSpawnSize(new Vector3(Random.Range(1, 2),Random.Range(1, 4), Random.Range(1, 2)));

            houseX = rndSizeCached.x;
            houseY = rndSizeCached.y;
            houseZ = rndSizeCached.z;
        }

    }

    public override void Update()
    {
        SetHouseSize(new Vector3(houseX,houseY,houseZ));
    }

}
