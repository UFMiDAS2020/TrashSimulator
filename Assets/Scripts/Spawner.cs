using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {
    public ToggleGroup toggleGroup;
    public Slider objectSlider;
    public Rigidbody objectToSpawn;
    public float timeOffset = 2f;

    private int numberOfObjectsToSpawn;
    private float timer;
    private bool spawning;

    private void Start()
    {
        timer = timeOffset;
    }

    private void Update()
    {
        if (spawning)
        {
            
            if (timer <= 0f)
            {
                if (numberOfObjectsToSpawn > 0)
                {
                    Rigidbody p = Instantiate(objectToSpawn, transform.position, UnityEngine.Random.rotation);
                    p.velocity = transform.forward * 10;
                }
                numberOfObjectsToSpawn--;
                timer = timeOffset;
            }
            timer -= Time.deltaTime;
            if (numberOfObjectsToSpawn <= 0) spawning = false;
        }
    }

    public void SpawnObjects()
    {
        if (!spawning)
        {
            int multiplier = GetMultiplier();
            numberOfObjectsToSpawn = (int)Math.Floor(objectSlider.value) * multiplier;
            spawning = true;
        }
    }

    public int GetMultiplier()
    {
        Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
        if (toggle.name == "Yearly Toggle") return 1;
        else if (toggle.name == "Monthly Toggle") return 12;
        else return 52;
    }
}
