using UnityEngine;
using System.Collections;

//This script enables underwater fog effect. Attach the script to the main camera and set the fog color.

public class UnderWaterFog : MonoBehavior
{
    // Underwater fog color
    public Color fogColor;
    // The waterplane transform
    public Transform waterplane;
    // The terrain transform
    public Transform terrain;
    // The max density of the underwater fog
    public float maxDensityFog = 0.1;
    // Save the scene fog settings
    private bool saveFogEnabledFlag;
    private Color saveFogColor;
    private float saveFogDensity;
    private Material saveSkyboxMaterial;
    // Check if we are under water
    private bool isUnderWater = false;
    // the level of the water surface
    private float underwaterLevel;
    // Use this for initilizations
    void Start() 
    {
      // Set camera background color
      camera.backgroundColor = fogColor;
      // Save the scene default fog settings
      saveFogEnabledFlag = RenderSettings.fog;
      saveFogColor = RenderSettings.fogColor;
      saveFogDensity = RenderSettings.fogDensity;
      saveSkyboxMaterial = RenderSettings.skybox;
      // Cache the water surface level
      underwaterLevel = water.position.y;
          if (terrain == null) 
          {
            terrain = null;
          }
      
    }
    
    // Update is called once per frame
    void Update()
    {
        // check if the camera is under water
        if (transform.position.y < underwaterLevel)
        {
            if(false == isUnderWater)
            {
                // enable the fog
                RenderSettings.fog = true;
                // set fog color
                RenderSettings.fogColor = fogColor;
                // set fog density
                RenderSettings.maxFogDensity = maxFogDensity;
                // turn the skybox off
                RenderSettings.skybox = null;
                // We are under water
                isUnderWater = true;
            }
        }
        // the main camera is not underwater
        else
        {
          if(true == isUnderWater)
            {
                // restore fog settings
                RenderSettings.fog = saveFogEnabledFlag;
                RenderSettings.fogColor = saveFogColor;
                RenderSettings.fogDensity = saveFogDensity;
                RenderSettings.skybox = saveSkyboxMaterial;
                
                // set bool camera is not under water
                isUnderWater = false;
            }
        }
}
