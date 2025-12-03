using UnityEngine;
using UnityEngine.Events;

namespace XR_Project_Example.Core.Conditions
{
    public class ComponentTagCondition : MonoBehaviour
    {
        public string Tag;

        public UnityEvent OnConditionTrue;

        public void CheckCondition(Component component)
        {
            if(component.gameObject.CompareTag(Tag))
            {
                OnConditionTrue?.Invoke();
            }
        }
    }
}