using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockKey_3 : MonoBehaviour
{
    bool used;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerController.Instance.unlocked_Key_3)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !used)
        {
            used = true;
            PlayerController.Instance.unlocked_Key_3 = true;
            Destroy(gameObject);
        }
    }
}
