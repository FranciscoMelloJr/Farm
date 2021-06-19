using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGM : MonoBehaviour 
{

    public Transform grassObj;
    public static string currentTool = "none";

    public static int sunflowerSeeds = 3;
    public static int potatoSeeds = 7;
    public static int carrotSeeds = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int xPos = -10; xPos < 12; xPos += 2)
        {
            for(int yPos = 5; yPos > -6; yPos -= 2)
            {
                Instantiate(grassObj, new Vector2(xPos, yPos), grassObj.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
