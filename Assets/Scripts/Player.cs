using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // variables taken from CharacterController.Move example script
    // https://docs.unity3d.com/ScriptReference/CharacterController.Move.html

    public AudioSource jumpSound;
	public float speed = 6.0F;
    public float airSpeed = 2.0F;
    public float jumpSpeed = 8.0F;
    public float maxJumpTime = 0.3f; // max time the jump button can be held in seconds
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
    private Vector3 bulletmoveDirection = Vector3.zero;
    
    private float jumpTime = 0.0f;
    private bool falling = false;
	private Vector3 lastPosition;

    private float jumpTime = 0.0f;
    private bool falling = false;
	private Vector3 lastPosition;

	public int Lives = 3; // number of lives the player hs
    public int coins = 0;
<<<<<<< HEAD
	Vector3 start_position; // start position of the player
    public GameObject bullet;
=======
>>>>>>> origin/master

    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;


	void Start()
	{
		// record the start position of the player
		start_position = transform.position;
		lastPosition = start_position;
	}

	public void Reset()
	{
		// reset the player position to the start position
		transform.position = start_position;
	}
    public void jump()
    {
        moveDirection.y = jumpSpeed;
    }
<<<<<<< HEAD

    public void fire()
    {
 
        if (Input.GetKeyDown("f"))
        {
           // Instantiate(bullet, new Vector3(this.transform.position.x + 2.0f, this.transform.position.y, this.transform.position.z), Quaternion.identity);

          //  bullet.transform.Translate(Vector3.right * speed);

            Instantiate(bullet, new Vector3(this.transform.position.x + 2.0f, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            
        }
    }
=======
>>>>>>> origin/master

	void Update()
	{

        fire();
		// get the character controller attached to the player game object
		CharacterController controller = GetComponent<CharacterController>();

		lastPosition = transform.position;

		// set the movement direction based on user input and the desired speed
		
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            // reset jump height
            falling = false;
            jumpTime = 0.0f;
        }

		// check to see if the player should jump
		if (Input.GetButton("Jump") && falling == false && jumpTime <= maxJumpTime)
		{
            if (jumpTime == 0.0f)
                jumpSound.Play();
            jumpTime += Time.deltaTime;
			moveDirection.y = jumpSpeed;
		}
        else
        {
            jumpTime -= Time.deltaTime;
            falling = true;
        }

		// apply gravity to movement direction
		moveDirection.y -= gravity * Time.deltaTime;

		// make the call to move the character controller
		controller.Move(moveDirection * Time.deltaTime);

	}
}





