using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

public class AnimationStateController : MonoBehaviour
{
    //[SerializeField] private InputAction runArrows;
    Animator animator;
    // string data type to grab isWalking
    int isWalkingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool walkPress = Input.GetKey("w");

        // if player presses w key
        if (!isWalking && walkPress) {
            animator.SetBool(isWalkingHash, true);
        }

        // if player is not pressing w key
        if (isWalking && !walkPress)
        {
            // then set the isWalking boolean to be false
            animator.SetBool(isWalkingHash, false);
        }

    }
}
