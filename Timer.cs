using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.EventSystems;


public struct Timer
{
    private float Timeset;
    public bool IsUp() { return Timeset<0; }
    public void Set(float time) { Timeset = time; }
    public void update(float dt) { Timeset -= dt; }
}

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 stpos;
    Vector3 endPos;
    Timer tm;
    // Start is called before the first frame update
    void Start()
    {
        tm.Set(-1);
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if (tm.IsUp())
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    tm.Set(2);
                }
                if (touch.phase == TouchPhase.Began )
                {
                    Debug.Log(Time.deltaTime.ToString());
                }
            }

        }
        if(!tm.IsUp())tm.update(Time.deltaTime);
        
        
    }
}
