using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter),typeof(MeshRenderer))]
public class House : MonoBehaviour
{

    [Header("House ObjectReference")]
    [SerializeField]
    private GameObject houseOBJ;

    [Header("House Size")]
    [Range(-10, 10)]
    public float houseX = 1f;

    [Range(-10, 10)]
    public float houseY = 1f;

    [Range(-10, 10)]
    public float houseZ = 1f;

    [HideInInspector]
    public Vector3 rndSizeCached = new Vector3(0,0,0);


    public virtual void Start()
    {
        SetHouseReference();

    }

    public virtual void Update()
    {
        SetHouseSize(new Vector3(houseX,houseY,houseZ));

    }

    public void SetHouseReference()

    {
        if(houseOBJ == null)
        {
            houseOBJ = this.gameObject;
        }
    }

    public Vector3 SetHouseSize(Vector3 houseSize)
    {
        transform.localScale = houseSize;
        return houseSize;
    }

    public virtual Vector3 RandomSpawnSize(Vector3 rndSize)
    {
        transform.localScale = rndSize;
        rndSizeCached = rndSize;
        return rndSize;
    }

}
