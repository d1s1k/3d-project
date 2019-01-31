using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour { 

    public enum rotateonAxes
{
    MouseXAndY = -0,
        mouseX = 1,
        mouseY = 2,




}

    public rotateonAxes axes = rotateonAxes.MouseXAndY;
     public float sensivitiHor = 9.0f

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if(axes == rotateonAxes.mouseX);
        {

            transform.rotation(0, Input.GetAxis("mouse X") * sensivitiHor, 0);
        }else if (axes == rotateonAxes.mouseY) ;

        else;



    }
}
