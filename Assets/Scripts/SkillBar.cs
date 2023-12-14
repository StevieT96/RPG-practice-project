using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkillBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxSP (int SP)
    {
        slider.maxValue = SP;
        slider.value = SP;
    }

    public void SetSP (int SP)
    {
        slider.value = SP;
    }
}
