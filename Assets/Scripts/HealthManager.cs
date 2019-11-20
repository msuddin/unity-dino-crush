﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    public int health;
    public TextMeshProUGUI healthAmount;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }

    public void reduceHeealth(int damageTaken)
    {
        this.health = health - damageTaken;
        this.healthAmount.text = this.health.ToString();
    }

}