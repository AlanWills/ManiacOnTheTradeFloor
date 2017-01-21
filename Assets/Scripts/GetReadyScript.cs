using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetReadyScript : MonoBehaviour
{
    public List<Sprite> textures;
    public float delay = 1.0f;

    private SpriteRenderer spriteRenderer;
    private float currentTimer = 0;
    private int currentIndex = 0;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponentInParent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer > delay)
        {
            if (currentIndex < textures.Count)
            {
                spriteRenderer.sprite = textures[currentIndex];
                currentIndex++;
                currentTimer = 0;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
        
    }
}
