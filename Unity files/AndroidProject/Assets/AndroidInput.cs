using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidInput : MonoBehaviour {

    public float minTouchDistance;
    public Material pushed;
    public Material normal; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Touch[] t = Input.touches; 
        for (int i = 0; i < t.Length; i++)
        {
            if (Vector2.Distance(t[i].position, transform.position) < minTouchDistance)
            {
                Pushed(); 
            }
        }
	}

    void Pushed()
    {
        if (pushed != null)
        {
            GetComponent<Renderer>().material = pushed;
        }
    }
}
