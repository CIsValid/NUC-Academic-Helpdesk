using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallHouse : House
{
    [Space(5)]
    [Header("Min & Max House Size")]
    [SerializeField]
    [Range(-10, 10)]
    private float minS = -10;
    [SerializeField]
    [Range(-10, 10)]
    private float maxS = 10;

    public override void Start()
    {

        SetHouseReference();

        if(randStartSize)
        {
            RandomSpawnSize(new Vector3(), Random.Range(1, 2),Random.Range(1, 6), Random.Range(1, 2));

            houseX = rndSizeCached.x;
            houseY = rndSizeCached.y;
            houseZ = rndSizeCached.z;
        }

    }

    public override void Update()
    {
        SetHouseSize(ClampSize(new Vector3(), minS, maxS));
    }

}
