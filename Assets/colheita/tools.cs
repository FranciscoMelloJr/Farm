using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tools : MonoBehaviour
{ 
    public Transform cursorObj;
    public Transform seedInvObj;
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
        if (gameObject.name == "scythe")
        {
            ScriptGM.currentTool = "scythe";
        }
        if (gameObject.name == "seeds")
        {
           // ScriptGM.currentTool = "seeds";
            seedInvObj.transform.position = new Vector2(3, 3);
        }
        if (gameObject.name == "bucket")
        {
            ScriptGM.currentTool = "bucket";
        }

        cursorObj.transform.position = transform.position;

        //Debug.Log (ScriptGM.currentTool);
    }
}
