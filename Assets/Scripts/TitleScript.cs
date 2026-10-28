using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TitleScript : MonoBehaviour
{
    // Drag your FlashImage GameObject here in the Inspector
    public Animator flashAnimator;

    // This method name must match the Animation Event exactly
    public void TriggerScreenFlash()
    {
        if (flashAnimator != null)
        {
            // Plays the flash animation from the beginning
            flashAnimator.Play("ScreenFlash", -1, 0f);
        }
    }
}
