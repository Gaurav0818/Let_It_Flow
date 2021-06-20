using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider slider;
    public int energy;
    public int maxEnergy;

    private void Update()
    {
        slider.maxValue = maxEnergy;
        slider.value = energy;
    }
}
