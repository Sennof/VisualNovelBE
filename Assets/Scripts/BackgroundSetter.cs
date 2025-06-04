using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BackgroundSetter : MonoBehaviour
{
    [SerializeField] private Image _backgroundImage;
    [SerializeField] private CharacterUISetter _characterUISetter;

    private Coroutine _movingCor = null;
    private Tween _currentAnimation = null;

    private Sprite _characterImage;

    public void SetBackground(Sprite? image, BgOffsetEnum offsetType, Sprite characterImage)
    {
        if (image != null)
            SetImage(image);

        if(_characterImage != null)
            _characterImage = null;

        if(_movingCor != null)
        {
            StopCoroutine(_movingCor);
            _movingCor = null;
        }

        if (_currentAnimation != null)
        {
            _currentAnimation.Kill();
            _currentAnimation = null;
        }

        _characterImage = characterImage;

        switch (offsetType)
        {
            case BgOffsetEnum.Left:
                _movingCor = StartCoroutine(AlignLeft());
                break;
            case BgOffsetEnum.Right:
                _movingCor = StartCoroutine(AlignRight());
                break;
            case BgOffsetEnum.Center:
                _movingCor = StartCoroutine(AlignCenter());
                break;
        }
    }

    private void SetImage(Sprite image) => _backgroundImage.sprite = image;

    private IEnumerator AlignCenter()
    {
        _currentAnimation = _backgroundImage.transform
            .DOMoveX(0 + 540, 1f);
        Debug.Log("Aligned to center");
        yield return _currentAnimation;
        _characterUISetter.CenterShow(_characterImage);
    }

    private IEnumerator AlignLeft()
    {
        _currentAnimation = _backgroundImage.transform
            .DOMoveX(1080 + 540, 1f);
        Debug.Log("Aligned to left");
        yield return _currentAnimation;
        _characterUISetter.LeftShow(_characterImage);
    }

    private IEnumerator AlignRight()
    {
        _currentAnimation = _backgroundImage.transform
            .DOMoveX(-1080 + 540, 1f);
        Debug.Log("Aligned to right");
        yield return _currentAnimation;
        _characterUISetter.RightShow(_characterImage);
    }
}
