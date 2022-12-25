using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Light : MonoBehaviour
{
    private float lightStrength;
    private bool maxStrength;

    void Start()
    {
        lightStrength = GetComponent<Light>().intensity;
        lightStrength = 0.2f;
        maxStrength = false;
    }

    void Update()
    {
        GetComponent<Light>().intensity = lightStrength;

        if (Test_GameManger.Spot_light)
        {
            if (0.7 <= lightStrength)
            {
                maxStrength = true;
            }

            if (lightStrength <= 0)
            {
                maxStrength = false;
            }

            if (maxStrength)
            {
                lightStrength -= 0.5f * Time.deltaTime;
            }
            else
            {
                lightStrength += 0.5f * Time.deltaTime;
            }
        }
        else
        {
            lightStrength = 1f;
        }
    }
}
