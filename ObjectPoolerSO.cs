using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectPoolingExample.ScriptableBase
{

    public abstract class ObjectPoolerSO<T> : ScriptableObject
    {

        [Serializable]
        protected struct PoolData
        {
            public T Object;
            public int AmountToSpawn;
            public bool InstantiateOnDemand;
            public bool CanBeUsedBeforeReleased;

        }
        protected struct PooledObjectData
        {
            public Queue<T> ObjectQueue;
            public bool InstantiateOnDemand;
            public bool CanBeUsedBeforeReleased;
        }
        [SerializeField] protected List<PoolData> Pool = new List<PoolData>();
        protected Dictionary<int, PooledObjectData> _pool = new Dictionary<int, PooledObjectData>();

        public abstract void Init();
        public abstract void Destroy(T obj);
        public abstract T Spawn(T obj, Vector3 spawnPosition, Quaternion spawnRotation, bool isActive = true);

    }
}
