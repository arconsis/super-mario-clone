using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private new Camera camera;
    private GameObject playerObject;
    private GameObject coinObject;

    void Start()
    {
        ConfigureCamera();

        playerObject = new GameObject("Player");
        playerObject.AddComponent<Player>();

        coinObject = new GameObject("Coin");
        coinObject.AddComponent<Coin>();
    }

    private void ConfigureCamera() {
        camera = GetComponent<Camera>();
        camera.backgroundColor = Color.black;
        camera.orthographicSize = 10;
    }
}
