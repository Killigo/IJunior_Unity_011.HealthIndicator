using UnityEngine;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    protected abstract void OnHealthChanged(float currentValue, float maxValue);
}
