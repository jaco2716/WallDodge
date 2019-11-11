using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseMenuUI;
    public GameObject PauseButton;

    
    private bool isPaused;

    public void ShowPauseMenu()
    {
        Animator animator = PauseMenuUI.GetComponent<Animator>();
        if (animator != null)
        {
            isPaused = animator.GetBool("Open");

            animator.SetBool("Open", !isPaused);
        }

        if (!isPaused)
        {
            PauseButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
            Time.timeScale = 0;
        }
        else
        {
            PauseButton.GetComponent<UnityEngine.UI.Button>().interactable = true;
            Time.timeScale = 1;
        }
    }

}
