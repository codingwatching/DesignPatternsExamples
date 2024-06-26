using UnityEngine;

namespace AbstractFactory
{
    public class HotrollFactory : AbstractFactory
    {
        private void Awake() => PoolSystem = new PoolSystem<GameObject>(_sushiPrefab, _poolSize, transform);
    }


}