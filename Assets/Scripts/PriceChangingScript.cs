using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceChangingScript : MonoBehaviour {

    private LineRenderer priceLine;
    private ObtainAmplitudesScript amplitudes;

    private Vector3[] positionBuffer;
    private float[] amplitudeBuffer;
    private const float xOffset = 0.1f;

    // Use this for initialization
    void Start()
    {
        priceLine = GetComponentInParent<LineRenderer>();
        amplitudes = GameObject.Find("AudioManager").GetComponent<ObtainAmplitudesScript>();
        GetComponentInParent<Rigidbody2D>().velocity = new Vector2(-1, 0);

        amplitudeBuffer = amplitudes.GetRenderData();
        positionBuffer = new Vector3[amplitudeBuffer.Length];
        priceLine.numPositions = amplitudeBuffer.Length;
        
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
