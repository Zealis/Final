﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBrightness : MonoBehaviour
{
    public float GammaCorrection;

    public Rect SliderLocation;

    void Update()
    {

        RenderSettings.ambientLight = new Color(GammaCorrection, GammaCorrection, GammaCorrection, 1.0f);

    }

    void OnGUI()
    {

        GammaCorrection = GUI.HorizontalSlider(SliderLocation, GammaCorrection, 0, 1.0f);

    }


}
