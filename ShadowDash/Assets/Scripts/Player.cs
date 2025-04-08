using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;


    [SerializeField] // private으로 쓸때
    private float moveSpeed;
    [SerializeField] // private으로 쓸때
    private float jumpForce;
    [SerializeField]
    private bool isMoving;
    private float xInput;

    void Start()
    {
        rb.linearVelocity = new Vector2(5, rb.linearVelocity.y);
    }


    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump");
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            Debug.Log("키눌리고있습니다.");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("키를 눌렀다가 놓을때");
        }
        */

        /*
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("버튼 눌렀습니다.");
        }
        */

        //Debug.Log(Input.GetAxis("Horizontal"));

        //Debug.Log(Input.GetAxisRaw("Horizontal"));

    }

    
}
