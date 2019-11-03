using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    private GameManager gameManager;
    public Sprite LifeSprite3;
    public Sprite LifeSprite2;
    public Sprite LifeSprite1;
    public Sprite LifeSprite0;


    public void ChangeLifeSprite(int lives)
    {
        if (lives >= 3) gameObject.GetComponent<Image>().sprite = LifeSprite3;

        else if (lives == 2) gameObject.GetComponent<Image>().sprite = LifeSprite2;

        else if (lives == 1) gameObject.GetComponent<Image>().sprite = LifeSprite1;

        else if (lives <= 0) gameObject.GetComponent<Image>().sprite = LifeSprite0;
    }

}
