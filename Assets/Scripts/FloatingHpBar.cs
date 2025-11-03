using System;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHpBar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateHealthBar(Character character)
    {
        slider.value = character.Health;
    }

    internal void UpdateHealthBar(GameObject gameObject)
    {
        throw new NotImplementedException();
    }
}
