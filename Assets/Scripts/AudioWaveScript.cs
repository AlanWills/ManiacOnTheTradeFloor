using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWaveScript : MonoBehaviour {

    private SpriteRenderer waveImage;
    private AudioSource audioSource;
    private bool triggeredPlay = false;

    public float Speed;

    // Use this for initialization
    void Start()
    {
        waveImage = GetComponentInParent<SpriteRenderer>();
        audioSource = GetComponentInParent<AudioSource>();

        // extents is half the length
        Speed = GetComponentInParent<BoxCollider2D>().bounds.extents.x * 2 / audioSource.clip.length;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggeredPlay)
        {
            AudioSource source = GetComponentInParent<AudioSource>();
            source.Play();
            triggeredPlay = true;
        }
    }

    void Update()
    {
        transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));
    }
}
