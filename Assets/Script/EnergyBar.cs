using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider slider;
    public int energy;
    public int maxEnergy;
    public bool fillEnergy;


    public GameObject energyFullPrefab;
    GameObject energyFullImage;

    float percentage;

    public Animator animator;
    

    private void Update()
    {
        perCalculator();

        statusAnimation();

        slider.maxValue = maxEnergy;
        slider.value = energy;

        if (fillEnergy == true)
        {
            EnergyFull();
            fillEnergy = false;
        }
    }
    public void EnergyFull()
    {
        energyFullImage = Instantiate(energyFullPrefab);
        energyFullImage.transform.SetParent(gameObject.transform);
    }

    public void statusAnimation()
    {
        if (percentage > 69)
        {
            animator.SetBool("100", true);
            animator.SetBool("50", false);
            animator.SetBool("20", false);
        }
        else if (percentage > 19 && percentage<70)
        {
            animator.SetBool("100", false);
            animator.SetBool("50", true);
            animator.SetBool("20", false);
        }
        else if (percentage < 20)
        {
            animator.SetBool("100", false);
            animator.SetBool("50", false);
            animator.SetBool("20", true);
        }
    }

    public void perCalculator()
    {
        percentage = energy * 100 / maxEnergy;
    }
}
