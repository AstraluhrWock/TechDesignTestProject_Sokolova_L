using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOne : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Update()
    {
        _button.onClick.AddListener(LoadingScene);
    }

    private void LoadingScene()
    {
        SceneManager.LoadScene("Scene_1");
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(LoadingScene);
    }
}
