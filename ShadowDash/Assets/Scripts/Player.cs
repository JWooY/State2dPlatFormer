using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;


    [SerializeField] // private���� ����
    private float moveSpeed;
    [SerializeField] // private���� ����
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
            Debug.Log("Ű�������ֽ��ϴ�.");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Ű�� �����ٰ� ������");
        }
        */

        /*
        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("��ư �������ϴ�.");
        }
        */

        //Debug.Log(Input.GetAxis("Horizontal"));

        //Debug.Log(Input.GetAxisRaw("Horizontal"));

    }

    
}
