using UnityEngine;
using UnityEngine.UI;

public class TextBar : Bar
{
    [SerializeField] private Text _text;

    protected override void OnHealthChanged(float currentValue, float maxValue)
    {
        _text.text = $"{Mathf.Round(currentValue)} / {Mathf.Round(maxValue)}";
    }
}
