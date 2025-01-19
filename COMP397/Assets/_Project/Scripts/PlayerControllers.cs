using UnityEngine;

namespace Platformer397
{
    public class PlayerControllers : MonoBehaviour

    {
        [SerializeField] private InputReader input;

        private void Start()
        {
            Debug.Log("[Start]");
            input.EanblePlayerActions();
        }

        private void OnEnable()
        {
            //Debug.Log("[OnEnable]");
            input.Move += GetMovement;


        }

        private void OnDisable()
        {
            //Debug.Log("[OnDisable]");
            input.Move -= GetMovement;
        }

        private void GetMovement(Vector2 move) 
        {
            Debug.Log("Input working" + move);
        }

    }
}
