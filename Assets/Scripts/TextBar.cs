using UnityEngine;
using UnityEngine.UI;

public class TextBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Text _text;

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
        _text.text = $"{(int)currentValue} / {(int)maxValue}";
    }
}
