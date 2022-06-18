using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using System;

public class LoadingSceneController : MonoBehaviour
{
    Action<IEnumerator> LoadDelegation;

    private static LoadingSceneController instance;
    public static LoadingSceneController Instance
    {
        get
        {
            if (instance == null)
            {
                var obj = FindObjectOfType<LoadingSceneController>();
                if(obj != null)
                {
                    instance = obj;
                }
                else
                {
                    instance = Create();
                }
            }
            return instance;
        }
    }

    private static LoadingSceneController Create()
    {
        return Instantiate(Resources.Load <LoadingSceneController>("LoadingUI"));
    }

    private void Start()
    {
        if (Instance != this)
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
            return;
        }
        SceneManager.sceneLoaded += OnSceneLoaded;
        DontDestroyOnLoad(gameObject);
    }

    [SerializeField] private CanvasGroup canvasgroup;
    [SerializeField] private Slider LoadingImage;

    private string loadSceneName;

    
    public void LoadScene(string sceneName, UnityAction<Scene,LoadSceneMode> callback=null)
    {
        SaveNLoadManager.Instance.RemoveAllDataPointer();
        gameObject.SetActive(true);
        if (callback != null)
            SceneManager.sceneLoaded += callback;
        loadSceneName = sceneName;
        StartCoroutine(LoadSceneProgress());
    }

    private IEnumerator LoadSceneProgress()
     {
        LoadingImage.value = 0f;
        yield return StartCoroutine(Fade(true));

        AsyncOperation op = SceneManager.LoadSceneAsync(loadSceneName);
        op.allowSceneActivation = false;
        

        float timer = 0f;
        while (!op.isDone)
        {
            yield return null;
            if(op.progress < 0.9f)
            {
                LoadingImage.value = op.progress;
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                LoadingImage.value = Mathf.Lerp(0.9f, 1f, timer);
                if(LoadingImage.value >= 1f)
                {
                    op.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Debug.Log("OnSceneLoaded");
        if(arg0.name == loadSceneName)
        {
            StartCoroutine(SaveNLoadManager.Instance.LoadData(arg0.name,Fade));
        }
    }
    
    private IEnumerator Fade(bool isFadeIn)
    {
        Debug.Log("Fade : " + isFadeIn);

        float timer = 0f;
        while (timer <= 1f)
        {
            yield return null;
            timer += Time.unscaledDeltaTime * 3f;
            canvasgroup.alpha = isFadeIn ? Mathf.Lerp(0f, 1f, timer) : Mathf.Lerp(1f, 0f, timer);
        }

        if (!isFadeIn)
        { 
            gameObject.SetActive(false);
        }
    }
}
