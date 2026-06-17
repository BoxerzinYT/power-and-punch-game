using UnityEngine.InputSystem;
using UnityEngine;

public class Move : MonoBehaviour
{
    float actualValueOfScaleX; //For "flipX" principal setting
    float speed;
    public float Speed { set { speed = value; }}
    Rigidbody2D rb;
    Animator anim;

    bool canMove = true;
    public void ChangeCanMove(bool can_){ canMove = can_; }

    public void Start()
    {
        actualValueOfScaleX = transform.localScale.x;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    //Move the player in the 8 directions
    public void OnMove(InputValue value)
    {
        if(canMove == true)
        {
            var moveInput = value.Get<Vector2>();
            FlipX(moveInput.x);
            rb.linearVelocity = moveInput.normalized * speed;
            //anim.SetBool("Moving", rb.linearVelocity.magnitude > 0);
        }
    }

    //Flip the player when he move to a different direction (x > 0 || x < 0)
    public void FlipX(float x)
    {
        float newX = (x < 0) ? newX = -actualValueOfScaleX : newX = actualValueOfScaleX; //Set the signal of "xOffset" var
        transform.localScale = new Vector3(newX, transform.localScale.y, transform.localScale.z);
    }
}
