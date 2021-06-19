using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantcontrol : MonoBehaviour
{

    public Sprite noPlantObj;
    public Sprite weedDead;

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

        if ((growTime > 7) && (watered == "n"))
        {
            currentSeed = "";
            growTime = 0;
            GetComponent<SpriteRenderer>().sprite = weedDead;
        }
        if ((growTime > 2) && (watered == "y"))
        {
            if (currentSeed == "girassol")
            {
                GetComponent<SpriteRenderer>().sprite = sunFlower2;
            }
            if (currentSeed == "cenoura")
            {
                GetComponent<SpriteRenderer>().sprite = carrot2;
            }
            if (currentSeed == "batata")
            {
                GetComponent<SpriteRenderer>().sprite = potato2;
            }
        }
    }

    void OnMouseDown() 
    {    
      //Debug.Log("clicked on weed");
        if (ScriptGM.currentTool == "foice")
        {
            GetComponent<SpriteRenderer>().sprite = noPlantObj;
        }

      //  if ((ScriptGM.currentTool == "seeds") && (GetComponent<SpriteRenderer>().sprite == noPlantObj))
      //  {
      //      GetComponent<SpriteRenderer>().sprite = sunFlower1;
      //  }

        if ((ScriptGM.currentTool == "girassol") && (GetComponent<SpriteRenderer>().sprite ==  noPlantObj))
        {
            GetComponent<SpriteRenderer>().sprite = sunFlower1;
            currentSeed = "girassol";
        }

        if ((ScriptGM.currentTool == "cenoura") && (GetComponent<SpriteRenderer>().sprite == noPlantObj))
        {
            GetComponent<SpriteRenderer>().sprite = carrot1;
            currentSeed = "cenoura";
        }

        if ((ScriptGM.currentTool == "batata") && (GetComponent<SpriteRenderer>().sprite == noPlantObj))
        {
            GetComponent<SpriteRenderer>().sprite = potato1;
            currentSeed = "batata";
        } 

        if (ScriptGM.currentTool == "balde")
        {
            plotObj.GetComponent<SpriteRenderer>().color = new Color(0.60f, 0.45f, 0.05f);
            watered = "y";
        }
    }
}
