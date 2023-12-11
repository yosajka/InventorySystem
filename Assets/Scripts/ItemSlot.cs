using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private Image _image;

    private Item _item;
    public Item Item {
        get { return _item; }
        set {
            _item = value;
            if (_item == null) {
                _image.enabled = false;
            }
            else {
                _image.sprite = _item.Icon;
                _image.enabled = true;
            }
        }
    }

    protected virtual void OnValidate()
    {
        if (_image == null)
            _image = GetComponent<Image>();
    }
}
