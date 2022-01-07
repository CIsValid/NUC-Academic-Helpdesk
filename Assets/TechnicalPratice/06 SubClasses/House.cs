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





    /* First we want to declare our default variables, for our house this means setting its sizes for example */
    [Header("House Size")]
    [Range(-100, 100)]
    public float houseX = 1f;

    [Range(-100, 100)]
    public float houseY = 1f;

    [Range(-100, 100)]
    public float houseZ = 1f;




    /* I also create a vector3 here which is just to store our random size at begin play though we use the HideInInspector tag here cause I dont feel like its nessesary information to show */
    [HideInInspector]
    public Vector3 rndSizeCached = new Vector3(0,0,0); // The variable still remains public though since we want to be able to edit / call it in our subclasses!




    /* This is to check if we should fetch a random size at begin play or if we should use the size set when we were in the editor */
    [Space]
    [Header("Checks")]
    public bool randStartSize = false;
    /* I also wanted to showcase how you can make use of variables in the parent script for example bools */




    // Methods marked with Virtual allow us to alter them in the subclass as you might want different functionallity. 
    public virtual void Start()
    {
        /* This is here since its the default behaviour we want, but also so i can show how we will override it in our subclass. Same with our update function */

        SetHouseReference();

    }






    public virtual void Update()
    {
        /* 
            This function updates the "house" size real time, if you'd want a more performant option you could choose to only do this if the value has changed.
            To make it even more performant you can ensure it only does it once but make use of a lerp to get the illusion its doing the same thing here.
        
            Point with this example was more to show that once we jump into our subclasses we will change their update functions.                     
         */

        SetHouseSize(new Vector3(houseX,houseY,houseZ));

    }






    public void SetHouseReference() 
    {
        /* The beauty of this is that regardless if the one who puts the script onto the object forgets to actually assign houseOBJ then it will do it automatically
            Hence the extra step in the begining assigning a requirecomponent header to the class, to ensure we are on a component thats valid to be assigned as "GameObject" :) */

        if(houseOBJ == null)
        {
            houseOBJ = this.gameObject;
        }

        /* We then call this method in the begin play that way we know that our object reference is not null! */
    }








    /* This is a method which returns a type, this we went over this during the method section. 
       Though to explain quickly what it does, in this case it tell the gameobject to set its scale to our returning vector which is in this instance houseSize
       This makes it so when we call the method we can make a vector consisting of our float size values and it will instantly set it if they change. */

    public Vector3 SetHouseSize(Vector3 houseSize)
    {
        houseOBJ.transform.localScale = houseSize;
        return houseSize;
    }

    /* I do want to make an observation here though, we are not using a virtual method here and thats cause we wont need to edit it in our subclass.
        But since we set it as public we can still use the functions across our subclasses. */







    /* Unlike our previous method here we actually want to be able to change functionality hence the virtual syntax being used here */
    public virtual Vector3 RandomSpawnSize(Vector3 rndSize, float x, float y, float z)
    {
        rndSize = new Vector3(x,y,z);
        houseOBJ.transform.localScale = rndSize;
        rndSizeCached = rndSize;
        return rndSize;
    }
    





    /* This is a method which allows our subclasses to clamp our house size since we may want our tall and small houses not to be able to exceed certain values! */
    public virtual Vector3 ClampSize(Vector3 clampedSize, float minS, float maxS) // The reason we have it as a virtual method is to allow us to override our minS and maxS with variables
    {
        clampedSize.x = Mathf.Clamp(houseX, minS, maxS);
        houseX = clampedSize.x;
        clampedSize.y = Mathf.Clamp(houseY, minS, maxS);
        houseY = clampedSize.y;
        clampedSize.z = Mathf.Clamp(houseZ, minS, maxS);
        houseZ = clampedSize.z;
        return clampedSize;
    } 
    /* The true power of methods like these is that they can be combined and you will see an example of this in the TallHouse subclass. 
        There we set the house size but clamp the values all in one line, elegant and readable code. */




}