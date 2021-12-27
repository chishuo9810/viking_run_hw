//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////Every movement about the viking,include collision,animation,changing direction.////////////////////////////////
///////////////////////////////Every movement about the viking,include collision,animation,changing direction.////////////////////////////////
///////////////////////////////Every movement about the viking,include collision,animation,changing direction.////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class PlayMovement : MonoBehaviour
{

    [SerializeField] float movingSpeed = 5f;
    [SerializeField]  float speed = 3f;

    private CharacterController myCharacterController;
    public int SceneIndexDestination = 0;
    public GameObject viking;
    public GameObject vikingEnemy;
    Animator animator;
    Rigidbody rb;
    Score score;

    public bool die;
    private bool run;
    private bool run2;
    public bool jump;
    public bool isJump;//inorder to prevent double jumping
    private bool turnLeft, turnRight;
    private bool tool;
    public static bool start;
    private float dieTime;
    public int direction;

    void Start()
    {
        tool = true;
        dieTime = 0;
        isJump = false;
        die = false;
        run = false;
        run2 = false;
        start = false;
        direction = 1;

        score = GameObject.Find("Canvas").transform.GetChild(2).gameObject.GetComponent<Score>();
        myCharacterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    //if trigger the sensor, than start the game(run automatically)
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.name == "Sensor")
        {
            start = true;
            run = true;
        }
    }

    //Collision judge about the viking
    void OnCollisionEnter(Collision collision)
    {
        if (start)//the collision judge start to work when the game start
        {
            run = true;
            isJump = false;
            if (collision.transform.name == "fence(Clone)" || collision.transform.name == "rock(Clone)")//if viking touch fence or rock ,then the viking die 
            {
                die = true;
                /*
                if (direction == 1)
                {
                    vikingEnemy.transform.position = new Vector3(viking.transform.position.x, viking.transform.position.y + 2, viking.transform.position.z - 5);
                }
                else if (direction == 3)
                {
                    vikingEnemy.transform.position = new Vector3(viking.transform.position.x - 5, viking.transform.position.y + 2, viking.transform.position.z);
                }
                else if (direction == 2)
                {
                    vikingEnemy.transform.position = new Vector3(viking.transform.position.x + 5, viking.transform.position.y + 2, viking.transform.position.z);
                }
                else if (direction == 4)
                {
                    vikingEnemy.transform.position = new Vector3(viking.transform.position.x, viking.transform.position.y + 2, viking.transform.position.z + 5);
                }*/
                //vikingEnemy.transform.position = TrailCamera.cameraP + 2 * transform.forward;
                vikingEnemy.transform.position = viking.transform.position; 
                animator.SetBool("Die", die);
                score.Stop();
            }
            else if (collision.transform.name == "Viking_Shield 1(Clone)")//if the viking touch the coin(shield),then the score add 100
            {
                Destroy(collision.gameObject);
                score.Add(100);
            }
        }
    }

    void Update()
    {
        if (start)//if the game start ,then start operating the function of the viking
        {
            jump = false;
            turnLeft = Input.GetKeyDown(KeyCode.A);
            turnRight = Input.GetKeyDown(KeyCode.D);

            if (!die)//if the viking does not die ,then he will keep going forward
            {
                transform.localPosition += movingSpeed * Time.deltaTime * transform.forward;
            }
            if (die && tool)
            {
                EnemyAttack.die = true;
                dieTime = Time.time;
                tool = false;
            }
            if (Time.time - dieTime > 3 && dieTime != 0)//if the viking die ,then after 3 second,it will turn to the scene which showing score
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(SceneIndexDestination);
            }

            if (turnLeft && !die)//turn left 
            {
                if (direction == 1)
                {
                    direction = 2;
                }
                else if (direction == 3)
                {
                    direction = 1;
                }
                else if (direction == 2)
                {
                    direction = 4;
                }
                else if (direction == 4)
                {
                    direction = 3;
                }
                transform.Rotate(new Vector3(0f, -90f, 0f));
            }
            else if (turnRight && !die)//turn right
            {
                if (direction == 1)
                {
                    direction = 3;
                }
                else if (direction == 3)
                {
                    direction = 4;
                }
                else if (direction == 2)
                {
                    direction = 1;
                }
                else if (direction == 4)
                {
                    direction = 2;
                }
                transform.Rotate(new Vector3(0f, 90f, 0f));
            }
            if (Input.GetKey(KeyCode.LeftArrow) && !die)//move left
            {
                transform.localPosition += speed * Time.deltaTime * transform.right * -1;
            }
            if (Input.GetKey(KeyCode.RightArrow) && !die)//move right 
            {
                transform.localPosition += speed * Time.deltaTime * transform.right;
            }
            if (Input.GetKeyUp(KeyCode.Space) && !isJump && !die)//small jump when press space 
            {
                rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
                jump = true;
                isJump = true;
                run = false;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow) && !isJump && !die)//big jump when press Uparrow
            {
                rb.AddForce(new Vector3(0, 8, 0), ForceMode.Impulse);
                jump = true;
                isJump = true;
                run = false;
            }
            if (viking.transform.position.y < 0)//the viking die if he fall down the floor
            {
                die = true;
                score.Stop();//if the viking,then stop counting the score 
            }


            animator.SetBool("Jump", jump);
            animator.SetBool("Run", run);
        }
        else//if the game does not start, then the viking can only go forward
        {
            run2 = false;
            if (Input.GetKey(KeyCode.W))//press W to go forward
            {
                run2 = true;
                transform.localPosition += speed * Time.deltaTime * transform.forward;
            }
            animator.SetBool("Run", run2);
        }
        if (Input.GetKey(KeyCode.Escape))//press esc to leave the game
        {
            Application.Quit(0);
        }
    }
}
