using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    static public event  Action enermyKilled;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    //void Update()
    //{

    //}
    private void OnDisable()
    {
        enermyKilled?.Invoke();
        Debug.Log("µÐÈË±»ÏûÃð£¡");
    }

}
