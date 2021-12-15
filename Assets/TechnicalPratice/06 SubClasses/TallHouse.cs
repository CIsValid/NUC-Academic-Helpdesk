using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallHouse : House
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
            RandomSpawnSize(new Vector3(Random.Range(1, 5),Random.Range(5, 15), Random.Range(1, 3)));

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
