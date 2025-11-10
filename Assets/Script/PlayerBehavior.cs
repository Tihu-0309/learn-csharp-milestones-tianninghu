using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float _vInput;
    private float _hInput;
    public float JumpVelocity = 5f;
    private bool _isJumping;
    // 1
    private Rigidbody _rb;

    enum PlayerAction { Attack = 10, Defend = 5, Flee };
    static PlayerAction CurrentAction = PlayerAction.Attack;
    static int ActionCost = (int)CurrentAction;

    public float DistanceToGround = 0.1f;
    public LayerMask GroundLayer;
    private CapsuleCollider _col;

    public GameObject Bullet;
    public float BulletSpeed = 100f;
    private bool _isShooting;
    private bool _isPaused = false;


    // 2
    void Start()
    {
        // 3
        _rb = GetComponent<Rigidbody>();

        _col = GetComponent<CapsuleCollider>();

    }


    // Update is called once per frame
    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;
        /*
        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
        */

        _isJumping |= Input.GetKeyDown(KeyCode.Space);

        _isShooting |= Input.GetKeyDown(KeyCode.F);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

    }
    
    private void TogglePause()
    {
        _isPaused = !_isPaused;

        if(_isPaused)
        {
            Time.timeScale = 0f;
            Debug.Log("Game Paused");
        }
        else
        {
            Time.timeScale = 1f;
            Debug.Log("Game Resume");
        }
    }

    //1
    void FixedUpdate()
    {
        //2
        Vector3 rotation = Vector3.up * _hInput;
        // 3
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        // 4
        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        // 5
        _rb.MoveRotation(_rb.rotation * angleRot);

        if (_isJumping)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }

        _isJumping = false;

        if (IsGrounded() && _isJumping)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);

        }

        if (_isShooting)
        {
            GameObject newBullet = Instantiate(Bullet, this.transform.position + new Vector3(0, 0, 1),
                this.transform.rotation);
            Rigidbody BulleyRB = newBullet.GetComponent<Rigidbody>();
            BulleyRB.linearVelocity = this.transform.forward * BulletSpeed;
        }

        _isShooting = false;

    }

    private bool IsGrounded()
    {
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x,
            _col.bounds.min.y, _col.bounds.center.z);

        bool grounded = Physics.CheckCapsule(_col.bounds.center,
            capsuleBottom, DistanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);

        return grounded;
    }

}
