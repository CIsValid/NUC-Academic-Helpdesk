using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* I use Requirecomponent attribute here cause i want it only to work on meshes. This means that if an object does NOT
    Have the components im looking for then it will automatically add the required components to the object!

    This is a quick error prevention and i'll be referencing this script in the future regarding error prevention as well. */

[RequireComponent(typeof(MeshFilter),typeof(MeshRenderer))] // This is god damn amazing, make use of it for scripts you know should only work on certain objects.
public class House : MonoBehaviour
{
    /* First lets grab a reference of our object.
    We could make due with by just using "transform.localscale" but like mentioned previously, it's better to actually have a variable to reference
    A reason why i say this is cause we will be using another error prevention fix in the SetHouseReference method in order to ensure houseOBJ have been assigned. */
    [Header("House ObjectReference")]
    [SerializeField]
    private GameObject houseOBJ;

    /*  */
    [Header("House Size")]
    [Range(-100, 100)]
    public float houseX = 1f;

    [Range(-100, 100)]
    public float houseY = 1f;

    [Range(-100, 100)]
    public float houseZ = 1f;

    [HideInInspector]
    public Vector3 rndSizeCached = new Vector3(0,0,0);

    [Space]
    [Header("Checks")]
    public bool randStartSize = false;

    // Methods marked with Virtual allow us to alter them in the subclass as you might want different functionallity. 
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
        /* The beauty of this is that regardless if the one who puts the script onto the object forgets to actually assign houseOBJ then it will do it automatically
            Hence the extra step in the begining assigning a requirecomponent header to the class :) */

        if(houseOBJ == null)
        {
            houseOBJ = this.gameObject;
        }
    }

    public Vector3 SetHouseSize(Vector3 houseSize)
    {
        houseOBJ.transform.localScale = houseSize;
        return houseSize;
    }

    public virtual Vector3 RandomSpawnSize(Vector3 rndSize, float x, float y, float z)
    {
        rndSize = new Vector3(x,y,z);
        houseOBJ.transform.localScale = rndSize;
        rndSizeCached = rndSize;
        return rndSize;
    }

    public virtual Vector3 ClampSize(Vector3 clampedSize, float minS, float maxS)
    {
        clampedSize.x = Mathf.Clamp(houseX, minS, maxS);
        houseX = clampedSize.x;
        clampedSize.y = Mathf.Clamp(houseY, minS, maxS);
        houseY = clampedSize.y;
        clampedSize.z = Mathf.Clamp(houseZ, minS, maxS);
        houseZ = clampedSize.z;
        return clampedSize;
    }

}
