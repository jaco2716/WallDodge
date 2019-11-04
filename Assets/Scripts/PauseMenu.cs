using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;

    public void ShowPauseMenu()
    {
        Animator animator = PauseMenuUI.GetComponent<Animator>();
        if (animator != null)
        {
            bool isPaused = animator.GetBool("Open");

            animator.SetBool("Open", !isPaused);
        }
    }

}
