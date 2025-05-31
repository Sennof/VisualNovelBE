using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CharacterUISetter : MonoBehaviour
{
    [SerializeField] private Image _characterImage;

    private Tween _currentAnimation = null;

    public void LeftShow(Sprite image)
    {
        SetImage(image);

        _currentAnimation = _characterImage.transform
            .DOMoveX(-300 + 540, 0.75f) //pos + canvas pos 
            .From(-800 + 540);
    }

    public void RightShow(Sprite image)
    {
        SetImage(image);

        _currentAnimation = _characterImage.transform
            .DOMoveX(300 + 540, 0.75f) //pos + canvas pos
            .From(800 + 540);
    }

    public void CenterShow(Sprite image)
    {
        SetImage(image);

        _currentAnimation = _characterImage.transform
            .DOMove(new Vector2(0 + 540, 0), 0.75f) //pos + canvas pos
            .From(new Vector2(0 + 540, 0 - 1400));
    }

    private void SetImage(Sprite image) 
    {
        _characterImage.sprite = image;

        if(_currentAnimation != null)
        {
            _currentAnimation.Kill();
            _currentAnimation = null;
        }
    }
}
