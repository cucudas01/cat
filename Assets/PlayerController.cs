using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float LeftMove = -3f;
    public float RightMove = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    public void LButtonDown()
    {
        transform.Translate(LeftMove, 0, 0);
    } 
    public void RButtonDown()
    {
        transform.Translate(RightMove, 0, 0);
    }
    
}
