using UnityEngine;

public class HitTarget : MonoBehaviour
{

    public GameObject underworld;
    public GameObject objectToHide;

	// Occurs when this object starts colliding with another
    void OnCollisionEnter(Collision collision)
    {
        // Hide the stage and show the underworld
        objectToHide.SetActive(false);
        underworld.SetActive(true);

        // Disable Spatial Mapping to allow the spheres to enter the underworld.
        SpatialMapping.Instance.SetMappingEnabled(false);
    }
}
