using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class ColorChange : MonoBehaviour {

    public Color cubeColor = new Color();

    public Renderer cubeRenderer;

	// Use this for initialization
	void Start () {
        cubeRenderer.material.color = cubeColor;
	}
	
	// Update is called once per frame
	void Update () {

        if (cubeRenderer.material.color != cubeColor)
        {
            cubeRenderer.material.color = cubeColor;
        }
    }
}
