using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(new Vector3(0, 0, forwardForce * Time.deltaTime));

        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(new Vector3(sidewaysForce * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(new Vector3((-1 * sidewaysForce) * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
        }

        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
