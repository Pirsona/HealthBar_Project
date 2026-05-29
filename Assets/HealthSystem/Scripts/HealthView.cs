using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected Health _health;

    private void OnEnable()
    {
        _health.HealthChanged += UpdateView;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= UpdateView;
    }

    protected abstract void UpdateView();
}
