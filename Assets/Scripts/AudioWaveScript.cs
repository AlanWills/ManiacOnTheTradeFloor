using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWaveScript : MonoBehaviour {

    private bool triggeredPlay = false;
    private AudioSource audioSource;
    private BoxCollider2D waveCollider;
    private float[] audioData;

    public float Speed;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponentInParent<AudioSource>();
        waveCollider = GetComponentInParent<BoxCollider2D>();

        // extents is half the length
        Speed = waveCollider.bounds.extents.x * 2 / audioSource.clip.length;

        audioData = new float[audioSource.clip.samples * audioSource.clip.channels];
        audioSource.clip.GetData(audioData, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggeredPlay)
        {
            AudioSource source = GetComponentInParent<AudioSource>();
            source.Play();
            triggeredPlay = true;
            waveCollider.enabled = false;
        }
    }

    void Update()
    {
        transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));
    }

    public float GetCurrentAmplitudeMagnitude()
    {
        int sampleTime = (int)(audioSource.clip.frequency * audioSource.time);
        return Math.Abs(audioData[sampleTime]);
    }
}
