using System;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHpBar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateHealthBar(float Health, float maxHp)
    {
        slider.value = Health / maxHp;
    }

    
}
