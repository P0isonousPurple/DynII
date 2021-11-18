using UnityEngine;
using UnityEngine.UI;


namespace DynII
{
    [System.Serializable]
    public class IconSwitch
    {
        public string Name;

        [Header("In order: PC Icon, PS4 Icon, XBox Icon")]
        public Sprite[] DeviceIcons = new Sprite[3];

        [Header("Sprites to Switch")]
        public SpriteRenderer[] SwitchableIcons;
        [Header("UI Images to Switch")]
        public Image[] SwitchableUIImages;
    }
}