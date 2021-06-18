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
        if (gameObject.name == "girassolTxt") 
        {
            GetComponent<TextMesh>().text = "Sementes de Girassol :" + ScriptGM.sunflowerSeeds;
        }
        if (gameObject.name == "cenouraTxt")
        {
            GetComponent<TextMesh>().text = "Sementes de Cenoura :" + ScriptGM.carrotSeeds;
        }
        if (gameObject.name == "batataTxt")
        {
            GetComponent<TextMesh>().text = "Sementes de batata  :" + ScriptGM.potatoSeeds;
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "girassolTxt")
        {
            ScriptGM.currentTool = "girassol";
        }
        if (gameObject.name == "cenouraTxt")
        {
            ScriptGM.currentTool = "cenoura";
        }
        if (gameObject.name == "batataTxt")
        {
            ScriptGM.currentTool = "batata";
        }
    }
}
