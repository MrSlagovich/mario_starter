using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    // Coin rotation speed in degrees per second
    public AudioSource coinSound;
    public float rotationSpeed = 180.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Player>().coins++;
            coinSound.Play();
            transform.position = Vector3.one * 9999999f;
            Destroy(gameObject, coinSound.clip.length);
        }
    }

}
