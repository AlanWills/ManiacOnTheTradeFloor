using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVisualiserScript : MonoBehaviour {

    private LineRenderer priceLine;
    private AudioInfoScript amplitudes;

    private Vector3[] positionBuffer;
    private float[] amplitudeBuffer;
    private const float xOffset = 0.05f;

    // Use this for initialization
    void Start()
    {
        priceLine = GetComponentInParent<LineRenderer>();
        Material whiteDiffuseMat = new Material(Shader.Find("Unlit/Texture"));
        priceLine.material = whiteDiffuseMat;

        amplitudes = GameObject.Find("AudioManager").GetComponent<AudioInfoScript>();

        amplitudeBuffer = amplitudes.GetRenderData();
        positionBuffer = new Vector3[amplitudeBuffer.Length];
        priceLine.numPositions = amplitudeBuffer.Length;

        GetComponentInParent<Rigidbody2D>().velocity = new Vector2(-amplitudes.RenderSampleRate * xOffset * amplitudes.Clip.channels, 0);
        
        for (int i = 0; i < amplitudeBuffer.Length; ++i)
        {
            positionBuffer[i] = new Vector3(xOffset * i, amplitudeBuffer[i] * 10);
        }

        priceLine.SetPositions(positionBuffer);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
