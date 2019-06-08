using UnityEngine;

public class gunscript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    public Rigidbody rb;

    private void Start()
    {

    }


    // Update is called once per frame
    void Update () {
        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

            //rb.AddForce(-50, -50, 0, ForceMode.Impulse);
        }

    }

    void Shoot()
    {
        muzzleFlash.Play();

        /*RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }

            GameObject ImpactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(ImpactGO, 2f);/
        }
        */
    }
}
