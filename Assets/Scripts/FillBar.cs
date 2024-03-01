using UnityEngine;
using UnityEngine.UI;

public class FillBar : Bar
{
    [SerializeField] private Image _bar;
    [SerializeField] private Color _color;

    protected override void OnChangeHealth(float currentValue, float maxValue)
    {
        float value = currentValue / maxValue;
        _bar.fillAmount = value;
        _bar.color = _color;
    }
}