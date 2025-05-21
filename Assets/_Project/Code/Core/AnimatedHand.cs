using UnityEngine;
using UnityEngine.InputSystem;

namespace TestProject.Core
{
    public class AnimatedHand : MonoBehaviour
    {
        [SerializeField] private InputActionProperty _pinchAnimationAction;
        [SerializeField] private InputActionProperty _gripAnimationAction;
        [SerializeField] private Animator _animator;

        void Update()
        {
            float triggerValue = _pinchAnimationAction.action.ReadValue<float>();
            _animator.SetFloat("Trigger", triggerValue);

            float gripValue = _gripAnimationAction.action.ReadValue<float>();
            _animator.SetFloat("Grip", gripValue);
        }
    }
}
