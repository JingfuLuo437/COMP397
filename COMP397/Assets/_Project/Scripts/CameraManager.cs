using Unity.Cinemachine;
using UnityEngine;

namespace Platformer397
{
    public class CameraManager : MonoBehaviour
    {
        // References to the CinemachineVituralCamera and the transform of our player
        [SerializeField] private CinemachineCamera FreeLookCam;
        [SerializeField] private Transform player;
        // In Awake , to lock the mouse into the Game view in unity and turn the cursor invisible
        private void Awake() {
           
            
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            if (player != null) { return; }
            
            player = GameObject.FindWithTag("Player").transform;
            
        }
        // On Enable, I want to associate the transform of our player into the target of your cinemachine camera
        private void OnEnable()
        {
            FreeLookCam.Target.TrackingTarget = player;

        }
    }
}
