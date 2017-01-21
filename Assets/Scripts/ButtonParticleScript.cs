using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ButtonParticleScript : MonoBehaviour
{
    public float LifeTime = 1;
    public float Rotation = 1;
    public float Speed = 1;

    private float timeAlive = 0;
    
	// Update is called once per frame
	void Update ()
    {
		if (gameObject.activeSelf)
        {
            timeAlive += Time.deltaTime;

            if (timeAlive > LifeTime)
            {
                Rigidbody2D rigidBody = GetComponentInParent<Rigidbody2D>();

                gameObject.SetActive(false);
                transform.localPosition = Vector3.zero;
                rigidBody.velocity = Vector2.zero;
            }
        }
	}

    public void Animate()
    {
        gameObject.SetActive(true);

        Rigidbody2D rigidBody = GetComponentInParent<Rigidbody2D>();
        timeAlive = 0;
        rigidBody.velocity = new Vector2(0, Speed);
        //rigidBody.angularVelocity = Rotation;
    }
}
