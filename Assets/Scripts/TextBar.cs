using UnityEngine;
using UnityEngine.UI;

public class TextBar : Bar
{
    [SerializeField] private Text _text;

    protected override void OnChangeHealth(float currentValue, float maxValue)
    {
        _text.text = $"{(int)currentValue} / {(int)maxValue}";
    }
}
