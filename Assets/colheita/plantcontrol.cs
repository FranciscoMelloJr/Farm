using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantcontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onMouseDown() 
    {    
      //Debug.Log("clicked on weed");
        if (ScriptGM.currentTool == "scythe")
        {
            Destroy(gameObject);
        }
    }
}
