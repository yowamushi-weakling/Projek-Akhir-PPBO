using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnSFX : MonoBehaviour
{
    public AudioSource mySFx;
    public AudioClip hoverSFx;
    public AudioClip clickSFx;

    public void HoverSound()
    {
        mySFx.PlayOneShot(hoverSFx);
    }
    public void ClickSound()
    {
        mySFx.PlayOneShot(clickSFx);
    }
}
