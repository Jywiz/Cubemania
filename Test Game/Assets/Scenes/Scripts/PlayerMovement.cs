using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; //f in the end means it's a float number

    // Use this for initialization
    void Start ()
    {

	}
	
	/* Update is called once per frame
       FixedUpdate NEEDS TO BE USED WHEN DEALING WITH PHYSICS!!*/
	void FixedUpdate ()
    {
        rb = GetComponent<Rigidbody>();
        //Makes the cube move by being pushed with forwardForce
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //Time.deltaTime stabilizes the frame updating across all computers

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameMngr>().EndGame();
        }
    }
}
