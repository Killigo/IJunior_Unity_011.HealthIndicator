using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Image _bar;
    [SerializeField] private Color _color;

    private void OnEnable()
    {
        _player.ChangeHealth += OnChangeHealth;
    }

    private void OnDisable()
    {
        _player.ChangeHealth -= OnChangeHealth;
    }

    private void OnChangeHealth(float currentValue, float maxValue)
    {
        float value = currentValue / maxValue;
        _bar.fillAmount = value;
        _bar.color = _color;
    }
}