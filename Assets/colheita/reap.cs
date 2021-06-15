using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reap : MonoBehaviour
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
        ScriptGM.currentTool = "scythe";
        // Debug.Log (ScriptGM.currentTool);
    }
}
