using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingLightToggle : MonoBehaviour
{
    [SerializeField] private Light ringLight; // Reference to the player's point light (ring light)

    private bool isLightOn = true; // Track the light state

    // Update is called once per frame
    void Update()
    {
        // Check if the player presses the 'F' key
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Toggle the light on/off
            isLightOn = !isLightOn;
            ringLight.enabled = isLightOn;
        }
    }
}
