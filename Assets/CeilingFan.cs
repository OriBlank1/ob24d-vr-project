using UnityEngine;

public class CeilingFan : MonoBehaviour
{
    [Header("Fan Settings")]
    [Tooltip("Speed of the fan in degrees per second.")]
    public float spinSpeed = 300f;

    [Tooltip("The axis the fan spins around. Usually (0, 1, 0) for the Y-axis.")]
    public Vector3 spinAxis = new Vector3(0, 1, 0);

    [Tooltip("Check this box to turn the fan on or off.")]
    public bool isOn = true;

    void Update()
    {
        // Only spin if the fan is turned on
        if (isOn)
        {
            // Rotate the object around the chosen axis
            // Time.deltaTime ensures it spins at the same speed regardless of framerate
            transform.Rotate(spinAxis * spinSpeed * Time.deltaTime);
        }
    }
}