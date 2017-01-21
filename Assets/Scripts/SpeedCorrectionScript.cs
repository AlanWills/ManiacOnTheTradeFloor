using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EdgeCollider2D))]
public class SpeedCorrectionScript : MonoBehaviour
{
    private AudioWaveScript wave;

    public float CorrectionSpeed;
    private float oldSpeed;

	// Use this for initialization
	void Start ()
    {
        wave = GameObject.Find("AudioWave").GetComponent<AudioWaveScript>();
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Marker")
        {
            oldSpeed = wave.Speed;
            wave.Speed = CorrectionSpeed;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Marker")
        {
            wave.Speed = oldSpeed;
        }
    }
}
