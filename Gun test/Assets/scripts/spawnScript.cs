using UnityEngine;

public class spawnScript : MonoBehaviour
{

    public GameObject Enemy;
    public float Crabtimer;
    public float Enemyamount;
    public Transform spawnpoint1;
    public Transform spawnpoint2;
    public Transform spawnpoint3;
    public Transform spawnpoint4;
    public 

    // Start is called before the first frame update
    void Start()
    {
        Crabtimer = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Crabtimer -= Time.deltaTime;

        if (Enemyamount <= 39 && Crabtimer <= 0)
        {
            Instantiate(Enemy, spawnpoint1.transform.position, transform.rotation);
            Crabtimer = 1;
            Enemyamount++;
        }     
    }
}
