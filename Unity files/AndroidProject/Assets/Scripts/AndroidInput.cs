using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidInput : MonoBehaviour {

    public bool usesAndroid; 

    public float minTouchDistance;
    public Material pushed;
    public Material normal;

    bool pushedMaterialActive = false;
    bool mouseStay = false;

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
            if (mouseStay && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Pushed();
            }
        }
	}
    
    void OnMouseEnter()
    {
        mouseStay = true; 
    }

    void OnMouseExit()
    {
        mouseStay = false; 
    }

    void OnMouseStay()
    {
        
    }
    
    void Pushed()
    {
        if (!pushedMaterialActive)
        {
            pushedMaterialActive = true; 
            GetComponent<Renderer>().material = pushed;
        }
        else
        {
            pushedMaterialActive = false; 
            GetComponent<Renderer>().material = normal;
        }
    }
}
