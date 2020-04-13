using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemPresenter : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Image Icon;

    public AudioClip BeginDragSound;
    public AudioClip EndDragSound;
    public AudioClip DropSound;

    private Item _currentItem = null;
    private Transform _transform;
    private RectTransform _holdParent;
    private RectTransform _dragParent;
    private AudioSource _audioSurce;


    private Vector3 CameraMain;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("start drop1: " + _transform.parent.name);
        _transform.parent = _dragParent;
        Debug.Log("start drop2: " + _transform.parent.name);
        _audioSurce.PlayOneShot(BeginDragSound);
    }

    public void OnDrag(PointerEventData eventData)
    {
        _transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!RectTransformUtility.RectangleContainsScreenPoint(_holdParent, Input.mousePosition))
        {
            _audioSurce.PlayOneShot(DropSound);
            CameraMain = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, Camera.main.nearClipPlane + 2));

            Debug.Log("start CameraMain: " + CameraMain);

            Instantiate(_currentItem.View, CameraMain, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            _audioSurce.PlayOneShot(EndDragSound);
        }

        transform.parent = _holdParent;
    }

    public void Present(Item item, RectTransform holdParent, RectTransform dragPerent, AudioSource audioSource)
    {
        Icon.sprite = item.Icon;
        _currentItem = item;
        _transform = GetComponent<Transform>();
        _holdParent = holdParent;
        _dragParent = dragPerent;
        _audioSurce = audioSource;
    }
}