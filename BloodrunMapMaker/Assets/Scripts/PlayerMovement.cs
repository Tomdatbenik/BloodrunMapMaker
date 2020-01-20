using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int speed;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb.MovePosition(rb.position + new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0f, Input.GetAxisRaw("Vertical") * Time.deltaTime * speed));
    }
}
