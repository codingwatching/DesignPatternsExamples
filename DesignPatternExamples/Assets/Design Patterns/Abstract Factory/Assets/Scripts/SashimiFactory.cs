using UnityEngine;

namespace AbstractFactory
{
    public class SashimiFactory : AbstractFactory
    {
        private void Awake() => _poolSystem = new PoolSystem<GameObject>(_sushiPrefab, _poolSize, transform);
    }
}