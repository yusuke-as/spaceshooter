using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject text;
    public EnemyBox box;

    public void GameOver()
    {
        text.SetActive( true );
        box.Stop();
        EnemyMove[] enemies = GameObject.FindObjectsOfType<EnemyMove>();
        foreach (var ene in enemies) {
            ene.enabled = false;
        }

    }
}
