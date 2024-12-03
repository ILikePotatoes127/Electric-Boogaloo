using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private float _move; 
    private Rigidbody2D _rb;
    private Animator _animator;
    private bool _isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _move = Input.GetAxis("Horizontal");
        _rb.linearVelocity = new Vector2(_move * speed, _rb.linearVelocity.y);

        if (_move < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (_move>0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _rb.AddForce(Vector2.up * jumpForce);
            _isGrounded = false;
            Debug.Log("Jump");
        }
        RunAnimations();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }

    private void RunAnimations()
    {
        _animator.SetFloat("Movement", Mathf.Abs(_move));
        _animator.SetBool("IsGrounded", _isGrounded);
    }
}
