using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    ParticleSystem ps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        Debug.Log("Projectile is colliding");
        ps.Play();
        Destroy(gameObject, 2f);
    }
}
