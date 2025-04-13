using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;
    Collider2D col;
    public bool isGround;
    public LayerMask whatIsGround;
    public GameObject upPoint;
    public GameObject downPoint;
    public static bool isAlive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isAlive = true;
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics2D.IsTouchingLayers(col, whatIsGround);//касается ли поверхности шар
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);//движение шара
        if (transform.position.y > upPoint.transform.position.y
            || transform.position.y < downPoint.transform.position.y)
        {
            isAlive = false;
        }
        //Debug.Log(isAlive);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround)//менять гравитацию только если касаемся поверхности
            {
                rb.gravityScale *= -1;
            }
        }
    }

    public bool IsAlive()
    {
        return isAlive;
    }
}
