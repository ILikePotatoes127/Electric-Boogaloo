using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement_Real : MonoBehaviour
{
    [Header("References")]
    public PlayerMovement_Stats MoveStats;
    [SerializeField] private Collider2D _feetColl;
    [SerializeField] private Collider2D _bodyColl;

    private Rigidbody2D _rb;

    //movement vars
    private Vector2 _moveVelocity;
    private bool _isFacingRight;

    //colission check vars
    private RaycastHit2D _groundHit;
    private RaycastHit2D _headHit;
    private bool _isGrounded;
    private bool _bumpedHead;

    private void Awake()
    {
        _isFacingRight = true;

        _rb = GetComponent<Rigidbody2D>();
    }
    

//    private void Move(float acceleration, float deceleration, Vector2 moveInput)
//    {
//        if (moveInput != Vector2.zero)
//        {
//            Vector2 targetVelocity = Vector2.zero;
//            if (PlayerMovement.RunIsHeld)
//            {
//                targetVelocity = new Vector2(moveInput.x, 0f) * MoveStats.MaxRunSpeed;
//            }
//            else { targetVelocity = new Vector2(moveInput.x, 0f) * MoveStats.MaxWalkSpeed; }

 //           _moveVelocity = Vector2.Lerp(_moveVelocity, targetVelocity, acceleration * Time.fixedDeltaTime);
//        }
        //
//    }

}
