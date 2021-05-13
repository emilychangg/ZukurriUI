using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfilePicture : MonoBehaviour
{
    public Image profile;
    public Image userImage;

    // Update is called once per frame
    void Update()
    {
        profile = userImage;
    }
}
