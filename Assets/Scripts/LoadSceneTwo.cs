using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneTwo : MonoBehaviour
{
    [SerializeField] private Button _button;

    private void Start()
    {
        _button.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _button.gameObject.SetActive(true);
            _button.onClick.AddListener(LoadingScene);
        }
    }

    private void LoadingScene()
    {
        SceneManager.LoadScene("Scene_2");
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(LoadingScene);
    }
}
