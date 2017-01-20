using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ObtainAmplitudesScript : MonoBehaviour
{
    private float[] AudioData;
    int renderSampleRate = 10;

    public AudioClip Clip { get; private set; }

	// Use this for initialization
	void Awake ()
    {
        Clip = gameObject.GetComponentInChildren<AudioSource>().clip;

        AudioData = new float[Clip.samples * Clip.channels];
        Clip.GetData(AudioData, 0);
    }

    public float[] GetRenderData()
    {
        int samples_per_100ms = Clip.frequency / renderSampleRate;
        float[] data = new float[(int)(Clip.length * renderSampleRate * Clip.channels)];

        for (int render_sample = 0; render_sample < data.Length; ++render_sample)
        {
            float max = 0;
            for (int n = 0; n < samples_per_100ms; ++n)
            {
                max = Math.Max(max, AudioData[render_sample * samples_per_100ms + n]);
            }

            data[render_sample] = max;
        }

        return data;
    }
}
