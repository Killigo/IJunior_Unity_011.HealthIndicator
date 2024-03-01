using UnityEngine;

public abstract class Bar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.ChangeHealth += OnChangeHealth;
    }

    private void OnDisable()
    {
        _player.ChangeHealth -= OnChangeHealth;
    }

    protected abstract void OnChangeHealth(float currentValue, float maxValue);
}
