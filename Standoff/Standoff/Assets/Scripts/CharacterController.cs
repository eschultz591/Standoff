using UnityEngine;
using UnityEngine.Events;

public class CharacterController : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject Shank;
    public Animator animator;
    #region Movement Variables
    [SerializeField] private float m_HorizontalSpeed;
    [SerializeField] private float m_VerticalSpeed;

    //limits speed of diagonal movement
    private float moveLimiter = .7f;
    private Vector3 MoveVector;
    private Vector3 m_Velocity = Vector3.zero;
    #endregion

    [SerializeField]
    private int health = 1;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

    }

    public void Move(float VSpeed, float HSpeed, Vector3 mouse)
    {

        transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);
        rb.velocity = new Vector3(HSpeed * moveLimiter, VSpeed * moveLimiter, 0);


    }
    
    public void Click(Vector3 mouseLocation)
    {
        
        animator.SetBool("Stabbing", true);

        //stuff from old project for creating blast
        /*Vector3 pos = mouseLocation;
        pos.z = 18;
        pos = Camera.main.ScreenToWorldPoint(pos);
        Instantiate(Attack, pos, Quaternion.identity);




        RaycastHit hit = new RaycastHit();


        Debug.DrawRay(transform.position, pos);
        Debug.Log("You clicked: " + (pos));
        */

    }

    public void TakeDamage(int damage)
    {
        Debug.Log("oof");
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void AnimationEnds()
    {
        animator.SetBool("Stabbing", false);
    }

}
