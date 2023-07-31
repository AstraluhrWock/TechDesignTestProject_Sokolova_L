using UnityEngine;

public class PlayAnimationOnClick : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private BoxCollider2D _boxCollider;
    private string animationName = "flower_animation";


    private void Start()
    {
        _animator = GetComponent<Animator>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _boxCollider != null)
        {
            _animator.Play(animationName);
            Debug.Log("On click");
        }
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }

}