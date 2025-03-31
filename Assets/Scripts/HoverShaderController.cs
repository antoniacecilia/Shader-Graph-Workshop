using UnityEngine;

public class HoverShaderController : MonoBehaviour
{
    // Reference to the Renderer component of the GameObject
    private Renderer rend;

    // Material instance used to control shader properties
    private Material mat;

    // Shader property ID for the hover effect
    private int hoverPropertyID;

    void Start()
    {
        // Get the Renderer component attached to this GameObject
        rend = GetComponent<Renderer>();

        // Get the material from the renderer (creates a unique instance of the material for this object)
        mat = rend.material;

        // Cache the shader property ID for optimization ("_IsHovered" should be a float property in your shader)
        hoverPropertyID = Shader.PropertyToID("_IsHovered");
    }

    // Called when the mouse cursor enters the object's collider
    void OnMouseEnter()
    {
        // Set the shader property to 1, indicating the object is hovered over
        mat.SetFloat(hoverPropertyID, 1);
    }

    // Called when the mouse cursor exits the object's collider
    void OnMouseExit()
    {
        // Set the shader property to 0, disabling the hover effect
        mat.SetFloat(hoverPropertyID, 0);
    }
}
