using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject Object;
    private float red = 1.0f, green = 0.0f, blue = 1.0f;
    // Start is called before the first frame update
    public void CambiarColor()
    {
        red = Random.Range(0.0f, 1.0f);
		green = Random.Range(0.0f,1.0f);
		blue = Random.Range(0.0f,1.0f);
        var NewObject = Object.GetComponent<Renderer>();
        // Create a new RGBA color using the Color constructor and store it in a variable
        Color customColor = new Color(red, green, blue, 1.0f);

        // Call SetColor using the shader property name "_Color" and setting the color to the custom color you created
        NewObject.material.SetColor("_Color", customColor);
    }

}
