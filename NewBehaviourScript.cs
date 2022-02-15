using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.EventSystems;



public class NewBehaviourScript : MonoBehaviour
{
    private float width;
    private float height;
    // Start is called before the first frame update
    void Start()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.touchCount>0)
        {
            
            Touch touch = Input.GetTouch(0);
            Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
            pos.z = 0;
            transform.position = pos;
            
            
           
        }
        
    }
}
