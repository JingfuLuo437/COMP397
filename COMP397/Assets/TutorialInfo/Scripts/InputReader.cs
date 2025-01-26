using UnityEngine;
using static InputSystem_Actions;
using UnityEngine.InputSystem;
using UnityEngine.Events;

namespace Platformer397
{
    [CreateAssetMenu(fileName = "InputReader", menuName = "Scriptable Objects/Inputreader")]
    public class InputReader : ScriptableObject, IPlayerActions
    {
        public event UnityAction<Vector2> Move = delegate { };

        InputSystem_Actions input;

        private void OnEnable() {
            if (input == null)
            { 
                input = new InputSystem_Actions();
                input.Player.SetCallbacks(this);
            }
        
        }

        public void EanblePlayerActions() { 
        
            input.Enable();
        }



        public void OnMove(InputAction.CallbackContext context) {
            Move?.Invoke(context.ReadValue<Vector2>());
            switch (context.phase) 
            {
                case InputActionPhase.Performed:
                case InputActionPhase.Canceled:
                    Move?.Invoke(context.ReadValue<Vector2>());
                    break;
                default:
                    Debug.Log("Not input handle");
                    break;
            }
        }
       public void OnLook(InputAction.CallbackContext context) { }
       public void OnAttack(InputAction.CallbackContext context) { }
        public void OnInteract(InputAction.CallbackContext context) { }
        public void OnCrouch(InputAction.CallbackContext context) { }
        public void OnJump(InputAction.CallbackContext context) { }
        public void OnPrevious(InputAction.CallbackContext context) { }
        public void OnNext(InputAction.CallbackContext context) { }
        public void OnSprint(InputAction.CallbackContext context) { }
    }
}

