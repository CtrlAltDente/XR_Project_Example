using UnityEngine;

namespace XR_Project_Example.Core.Objects
{
    public class GameObjectSpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject _prefab;

        public GameObject Spawn()
        {
            return Instantiate(_prefab);
        }
    }
}