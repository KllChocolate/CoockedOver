using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimator : NetworkBehaviour
{
    private const string IS_WALKING = "IsWalking";

    [SerializeField] private Player player;

    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();  
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner)
        { return; }
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
