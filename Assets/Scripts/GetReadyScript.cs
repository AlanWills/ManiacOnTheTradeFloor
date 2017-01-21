using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetReadyScript : MonoBehaviour
{
    public List<Sprite> textures;
    public float delay = 1.0f;

    private Image currentImage;
    private float currentTimer = 0;
    private int currentIndex = 0;

    // Use this for initialization
    void Start()
    {
        currentImage = GetComponentInParent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer > delay)
        {
            if (currentIndex < textures.Count)
            {
                currentImage.sprite = textures[currentIndex];
                currentImage.SetNativeSize();
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
