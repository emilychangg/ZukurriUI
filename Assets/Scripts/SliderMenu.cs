using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMenu : MonoBehaviour
{
    public GameObject PanelMenu;
    public GameObject Button;
    public GameObject GreyPanel;

    public void ShowHideMenu()
    {
        if (PanelMenu != null)
        {
            Animator animator = PanelMenu.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
                Button.SetActive(!isOpen);
                GreyPanel.SetActive(!isOpen);
            }
        }
    }
}
