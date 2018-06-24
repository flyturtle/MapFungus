using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour {
    public float maxcamx = 30f;
    public float maxcamy = 34f;    
    public GameObject Camera;
    public GameObject Controllobj;
    private readonly float Walktimes = 0.19f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Canmove();
        Debugs();

    }
  
    void Canmove()
    {
        if (!Flowchart_script.booltalk)
        {
            Move();
        }
    }
    private void Move()
    {
        var posx = Input.GetAxis("Horizontal");
        var posy = Input.GetAxis("Vertical");
        transform.Translate(Mathf.Clamp(posx, -Walktimes, Walktimes), Mathf.Clamp(posy, -Walktimes, Walktimes), 0);
        Vector3 rawpos = Camera.transform.position;
        Vector3 Controllops = Controllobj.transform.position;
        if (Controllops.x > maxcamx || Controllops.x < -maxcamx || Controllops.y > maxcamy || Controllops.y < -maxcamy)
        {
            Controllobj.transform.position = new Vector3(Mathf.Clamp(rawpos.x, (-1 * maxcamx), maxcamx), Mathf.Clamp(rawpos.y, (-1 * maxcamy), maxcamy), 0);
        }
    }
    private void Debugs() {
        //Debug.Log(Flowchart_script.Booltalking); 
        //Debug.Log(message: Mathf.Clamp(posx, -walktimes, walktimes) != 0 ? true : false);
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag=="City")
    //    {
    //        Debug.Log("Trigger" + other.gameObject.name);
    //    }
    //}
}
