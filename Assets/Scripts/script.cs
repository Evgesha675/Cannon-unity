using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float rotationSpeed = 120;
    public float speed = 5.5f;
    private Rigidbody rb;
    public GameObject projectile;

    private float can_fire = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(this.name);
        rb = GetComponent<Rigidbody>();    
    }
    void Update(){
        float fire = Input.GetAxis("Fire1");
        if (fire == 1 && fire != can_fire){
            GameObject projectile_clone;
            projectile_clone = Instantiate(projectile, transform.position + transform.forward + new Vector3(0, 0.25f, 0), transform.rotation);

            projectile_clone.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);


        }
        can_fire = fire;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = transform.forward * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);

        Debug.Log(Input.GetAxis("Horizontal"));
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
