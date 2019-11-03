using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToRotate : MonoBehaviour
{

    private bool touchActive = false;
    private float angle = 0;
    private Rigidbody2D rb2d;
    private bool gameOver = false;

    private ParticleSystem deathParticle;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        deathParticle = GetComponentInChildren<ParticleSystem>();
    }

    public void DeathParticle()
    {
        deathParticle.Play();
        StartCoroutine(DestroyPlayer());
        gameOver = true;
    }

    private IEnumerator DestroyPlayer()
    {
        rb2d.transform.localScale = new Vector3(0,0);
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {

            if (!touchActive)
            {
                touchActive = true;
                float xTouchPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x;

                if(xTouchPos < 0) angle += 45;
                else if (xTouchPos > 0) angle += 90;

                if(!gameOver) rb2d.MoveRotation(angle);
                
//                transform.rotation = Quaternion.AngleAxis(angle, Vector3.back);

                if (angle > 370) angle = 45;
                else if (angle > 350) angle = 0;
            }
        }

        if (Input.touchCount == 0)
        {
            touchActive = false;
        }
    }

}
