using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMenu : MonoBehaviour
{
    public Sprite menuButton;
    // Start is called before the first frame update
    public void ChangeColour()
    {
        GetComponent<Image>().sprite = menuButton;
    }
}
