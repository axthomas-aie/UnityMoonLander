﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour {

    public Transform obj;



    private void Update()
    {
        transform.LookAt(obj);
    }

}
