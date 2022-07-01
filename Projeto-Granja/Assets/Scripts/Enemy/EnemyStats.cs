using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : MonoBehaviour
{
    public int health;
    public int attack;
    public int defense;
    public int speed;

    //public Text hpEnemyText;

    [Header("DROPS E ITENS")]
    public GameObject[] itensDropados;
    // Start is called before the first frame update
    void Start()
    {
        //hpEnemyText = GameObject.FindGameObjectWithTag("EnemyHealth").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //hpEnemyText.text = "Enemy Health: " + health.ToString();

        if (health <= 0)
        {
            DropItem();
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
       health -= damage;
    }

    void DropItem()
    {
        GameObject item = Instantiate(itensDropados[0], gameObject.transform.position, Quaternion.identity);

    }
}
