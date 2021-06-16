using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantcontrol : MonoBehaviour
{

    public Sprite noPlantObj;
    public Sprite sunFlower1;
    public Sprite sunFlower2;

    public Sprite potato1;
    public Sprite potato2;

    public Sprite carrot1;
    public Sprite carrot2;

    public float growTime = 0;

    public Transform plotObj;
    public string watered = "n";

    public string currentSeed = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSeed != "") 
        {
            growTime += Time.deltaTime;
        }

        if ((growTime > 5) && (watered == "n")) 
        {
            currentSeed = "";
            growTime = 0;
            GetComponent<SpriteRenderer>().sprite = noPlantObj;
        }
        if ((growTime > 5) && (watered == "y"))
        {
            if (currentSeed == "sunflower") 
            {
                GetComponent<SpriteRenderer>().sprite = sunFlower2;
            }
            if (currentSeed == "carrot")
            {
                GetComponent<SpriteRenderer>().sprite = carrot2;
            }
            if (currentSeed == "potato")
            {
                GetComponent<SpriteRenderer>().sprite = potato2;
            }
        }

    }

    void OnMouseDown() 
    {    
      //Debug.Log("clicked on weed");
        if (ScriptGM.currentTool == "scythe")
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = noPlantObj;
        } 

        if ((ScriptGM.currentTool == "sunflower") && (GetComponent<SpriteRenderer>().sprite ==  noPlantObj))
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = sunFlower1;
            currentSeed = "sunflower";
        }
        if ((ScriptGM.currentTool == "carrot") && (GetComponent<SpriteRenderer>().sprite == noPlantObj))
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = carrot1;
            currentSeed = "carrot";
        }
        if ((ScriptGM.currentTool == "potato") && (GetComponent<SpriteRenderer>().sprite == noPlantObj))
        {
            //Destroy(gameObject);
            GetComponent<SpriteRenderer>().sprite = potato1;
            currentSeed = "potato";
        } 


        if (ScriptGM.currentTool == "bucket")
        {
            //Destroy(gameObject);
            plotObj.GetComponent<SpriteRenderer>().color = new Color(0,0,1);
            watered = "y";
        }
    }
}
