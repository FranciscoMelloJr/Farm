using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txtinfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "sunflowerTxt") 
        {
            GetComponent<TextMesh>().text = "Sementes de Girassol :" + ScriptGM.sunflowerSeeds;
        }
        if (gameObject.name == "carrotTxt")
        {
            GetComponent<TextMesh>().text = "Sementes de Cenoura :" + ScriptGM.carrotSeeds;
        }
        if (gameObject.name == "potatoTxt")
        {
            GetComponent<TextMesh>().text = "Sementes de batata  :" + ScriptGM.potatoSeeds;
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "sunflowerTxt")
        {
            ScriptGM.currentTool = "sunflower";
        }
        if (gameObject.name == "carrotTxt")
        {
            ScriptGM.currentTool = "carrot";
        }
        if (gameObject.name == "potatoTxt")
        {
            ScriptGM.currentTool = "potato";
        }
    }
}
