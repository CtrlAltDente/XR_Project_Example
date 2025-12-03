using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace XR_Project_Example.Core.Objects
{
    public class GameObjectPool : MonoBehaviour
    {
        [SerializeField]
        private GameObjectSpawner _spawner;

        [SerializeField]
        private int _poolSize = 10;

        private List<GameObject> _pool;

        private void Awake()
        {
            InitializePool();
        }

        public GameObject GetGameObject()
        {
            foreach (GameObject gameObject in _pool)
            {
                if (!gameObject.activeInHierarchy)
                {
                    gameObject.transform.SetParent(null);
                    gameObject.SetActive(true);
                    return gameObject;
                }
            }

            GameObject newGameObject = SpawnGameObject();
            newGameObject.SetActive(true);
            return newGameObject;
        }

        public void AddGameObject(GameObject gameObject)
        {
            gameObject.SetActive(false);
            gameObject.transform.SetParent(transform);
        }

        private void InitializePool()
        {
            _pool = new List<GameObject>();
            for (int i = 0; i < _poolSize; i++)
            {
                GameObject gameObject = SpawnGameObject();
                AddGameObject(gameObject);
            }
        }

        private GameObject SpawnGameObject()
        {
            GameObject gameObject = _spawner.Spawn();
            _pool.Add(gameObject);
            return gameObject;
        }
    }
}