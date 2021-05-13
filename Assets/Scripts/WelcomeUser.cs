using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeUser : MonoBehaviour
{
    public Text welcomeText;
    public string userName;

    // Update is called once per frame
    void Update()
    {
        welcomeText.text = "Welcome, " + userName + '!';
    }
}
