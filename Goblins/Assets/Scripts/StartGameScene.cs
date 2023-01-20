using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameScene : MonoBehaviour
{
    private Animator componentAnimator;
    private static bool startScene = true;
    private void Start()
    {
        componentAnimator = GetComponent<Animator>();
        if (startScene){
            componentAnimator.SetTrigger("StartGame");
            startScene = false;
        }
    }
    public void End() {
        GetComponent<StartGameScene>().enabled = false;
    }
}