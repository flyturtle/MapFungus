using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;

public class Flowchart_script : MonoBehaviour {
    public Flowchart flowchart;
    public static string Booltalking;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Bugs();
    }

    public static bool booltalk  {
        get { return GameObject.Find("GFlowchart").GetComponent<Flowchart>().GetBooleanVariable("booltalk"); }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            string targetname = this.gameObject.name;
            Block targetBlock = flowchart.FindBlock(targetname);
            flowchart.ExecuteBlock(targetBlock);
            flowchart.ExecuteBlock("Talking");
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            flowchart.ExecuteBlock("noTalking");
        }

    }
    void Bugs() {
        Debug.Log(GameObject.Find("GFlowchart").GetComponent<Flowchart>().GetBooleanVariable("booltalk"));
    }

}
