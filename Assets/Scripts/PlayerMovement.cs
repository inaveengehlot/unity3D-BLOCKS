using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f; // forward force variable z-axis
    public float sidewaysforce = 600f; // sideways force variable x-axis
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Adding a forward force using a variable
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if( Input.GetKey("d") ) // when D is pressed
        {
            rb.AddForce(sidewaysforce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if( Input.GetKey("a") ) // when A is pressed
        {
            rb.AddForce(-sidewaysforce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -7f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
