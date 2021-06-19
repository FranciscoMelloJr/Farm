using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tools : MonoBehaviour
{ 
    public Transform cursorObj;
    public Transform inventarioObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (gameObject.name == "foice")
        {
            ScriptGM.currentTool = "foice";
        }
        if (gameObject.name == "sementes")
        {
            //ScriptGM.currentTool = "sementes";
            inventarioObj.transform.position = new Vector2(6.75f, -3.75f);
        }
        else
        {
            inventarioObj.transform.position = new Vector2(13.5f, -3.75f);
        }
        if (gameObject.name == "balde")
        {
            ScriptGM.currentTool = "balde";
        }

        cursorObj.transform.position = transform.position;

        //Debug.Log (ScriptGM.currentTool);
    }
}
