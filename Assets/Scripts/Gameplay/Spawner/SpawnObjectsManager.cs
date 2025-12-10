using System.Collections.Generic;
using UnityEngine;
using XR_Project_Example.Core.Objects;
using XR_Project_Example.Gameplay.Basketball;

namespace XR_Project_Example.Gameplay.Spawning
{
    public class SpawnObjectsManager : MonoBehaviour
    {
        [SerializeField]
        private GameObjectPool _gameObjectPool;

        [SerializeField]
        private Transform _spawnPoint;

        private Queue<GameObject> _gameObjects = new Queue<GameObject>();

        public void Spawn()
        {
            GameObject gameObject = _gameObjectPool.GetGameObject();
            gameObject.transform.position = _spawnPoint.position;
            ResetVelocity(gameObject);

            _gameObjects.Enqueue(gameObject);
        }

        public void ClearAll()
        {
            while(_gameObjects.Count > 0)
            {
                GameObject gameObject = _gameObjects.Dequeue();
                _gameObjectPool.AddGameObject(gameObject);
            }
        }

        private void ResetVelocity(GameObject gameObject)
        {
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.linearVelocity = Vector3.zero;
            rigidbody.angularVelocity = Vector3.zero;
        }
    }
}

