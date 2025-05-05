using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class TestingNetcodeUI : MonoBehaviour
{
    [SerializeField] Button startHostButton;
    [SerializeField] Button startClientButton;

    private void Awake()
    {
        startHostButton.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();
            Hide();
            Debug.Log("Host");
        });
        startClientButton.onClick.AddListener(() => {
            NetworkManager.Singleton.StartClient();
            Hide();
            Debug.Log("Client");
        });
        
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
