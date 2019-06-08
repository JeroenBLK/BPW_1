using UnityEngine;

public class Target : MonoBehaviour{

    public GameObject Player;
    public float movementSpeed = 4;
    public spawnScript enemyCountScript;
    void Start()
    {
        enemyCountScript.Enemyamount++;
    }

    void Update()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "deathbox")
        {
            Die();
            FindObjectOfType<GameManager>().ExtraPoint();
        }
    }

    void Die ()
    {
        enemyCountScript.Enemyamount--;
        Destroy(gameObject);
    }

}
