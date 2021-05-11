using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerCollision))]
[RequireComponent(typeof(PlayerImage))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    private PlayerInput playerInput;
    private PlayerMovement playerMove;
    private PlayerCollision playerCollision;
    private PlayerImage playerImage;
    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        playerMove = GetComponent<PlayerMovement>();
        playerCollision = GetComponent<PlayerCollision>();
        playerImage = GetComponent<PlayerImage>();
    }
    private void Update()
    {
        Vector3 motion = new Vector3(playerInput.HAxis, 0f, playerInput.VAxis);
        playerMove.Move(motion, speed);
        if (playerInput.HAxis != 0f)
            playerImage.StartRotate();
        else if (playerInput.VAxis != 0f)
            playerImage.StartWalk();
        else
            playerImage.StartIdle();
    }
}
