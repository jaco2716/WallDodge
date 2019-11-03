using System;
using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Renderer renderer;
    Color color;
    private bool invisible;


    void Start()
    {
        renderer = GetComponent<Renderer>();
        color = renderer.material.color;

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Wall")
        {
            if (!invisible)
            {
                FindObjectOfType<GameManager>().LoseLife();
            }
            StartCoroutine(Invisible());
        }
    }

    IEnumerator Invisible()
    {
        invisible = true;
        Physics2D.IgnoreLayerCollision(8, 9, true);
        color.a = 0.5f;
        renderer.material.color = color;
        yield return new WaitForSeconds(2);
        color.a = 1;
        renderer.material.color = color;
        Physics2D.IgnoreLayerCollision(8, 9, false);
        invisible = false;
    }

    
}
