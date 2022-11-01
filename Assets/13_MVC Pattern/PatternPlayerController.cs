using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPlayerController : MonoBehaviour
{
    [SerializeField] private PatternPlayer playerModel;
    [SerializeField] private PatternPlayerView playerView;
    private Vector3 inputDirection;

    private void Start()
    {
        inputDirection = new Vector3();
        playerView.update(playerModel);
    }
    private void Update()
    {
        ControlPlayer();
    }

    private void ControlPlayer()
    {
        if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
        {
            inputDirection.x = Input.GetAxis("Horizontal");
            inputDirection.z = Input.GetAxis("Vertical");
            playerModel.Move(inputDirection, 5f);
            playerView.update(playerModel);
        }
    }
}
