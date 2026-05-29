using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _max;

    private float _min = 0;

    public float Current {get; private set;}
    public float Max => _max;

    public event Action OnDied;
    public event Action HealthChanged;

    private void Awake()
    {
        Current = _max;   
    }

    public void Heal(float count)
    {
        Current = Mathf.Min(Current + count, _max);

        HealthChanged?.Invoke();
    }

    public void TakeDamage(float count)
    {
        Current = Mathf.Max(Current - count, _min);

        if (Current <= 0)
        {
            OnDied?.Invoke();
        }

        HealthChanged?.Invoke();
    }

    public void ChangeHealth(float count)
    {
        if(count >= 0)
        {
            Heal(count);
        }
        else
        {
            TakeDamage(Mathf.Abs(count));
        }
    }
}