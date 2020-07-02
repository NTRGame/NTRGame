﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float maxHp = 100.0f;
    public float currentHp = 10.0f;
    private void Awake() 
    {
        currentHp =maxHp;          
    }
}
