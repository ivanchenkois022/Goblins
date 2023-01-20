using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneTransition : MonoBehaviour
{
    private Animator componentAnimator;
    private static SceneTransition instance;
    private static bool shouldPlayOpeningAnimation = false;
    private AsyncOperation LoadingSceneOperation;

    
    public static void SwitchToscene(string sceneName) {
        instance.componentAnimator.SetTrigger("SceneEnd");
        instance.LoadingSceneOperation = SceneManager.LoadSceneAsync(sceneName);
        instance.LoadingSceneOperation.allowSceneActivation = false;
    }
    void Start()
    {
        instance = this;
        componentAnimator = GetComponent<Animator>();
        
        if(shouldPlayOpeningAnimation)
            componentAnimator.SetTrigger("SceneStart");
    }


    void Update()
    {
        transform.GetChild(1).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = languageController.DText1;
    }

    public void OnAnimationOver() {
        shouldPlayOpeningAnimation = true;
        LoadingSceneOperation.allowSceneActivation = true;
    }
}
