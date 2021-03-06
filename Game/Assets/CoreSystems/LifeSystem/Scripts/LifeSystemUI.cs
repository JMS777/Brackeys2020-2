﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSystemUI : MonoBehaviour
{
    public GameObject HealthBarPrefab;

    private IEnumerable<HealthBar> healthBars;

    void Start()
    {
        var lifeSystems = FindObjectsOfType<LifeSystem>();
        var healthBars = new List<HealthBar>();

        foreach (var lifeSystem in lifeSystems)
        {
            var newObject = Instantiate(HealthBarPrefab, lifeSystem.transform);
            newObject.GetComponent<RectTransform>().localPosition = Vector3.up * 4;
            var newHealthBar = newObject.GetComponent<HealthBar>();

            newHealthBar.SetLifeSystem(lifeSystem);
            healthBars.Add(newHealthBar);
        }

        this.healthBars = healthBars;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
