using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidInput : MonoBehaviour {

    public bool usesAndroid; 

    public float minTouchDistance;
    public Material pushed;
    public Material normal; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (usesAndroid)
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
        else
        {
            
        }
	}

    void OnMouseEnter()
    {

    }

    void OnMouseStay()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Pushed(); 
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
