using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DynII
{
    public class IconManager : MonoBehaviour
    {
        public IconSwitch[] Switches;
        [Header("Device Schemes from the Input Action Asset")]
        [SerializeField] private string keyboardMouseScheme;
        [SerializeField] private string ps4Scheme;
        [SerializeField] private string xboxScheme;

        public void OnDeviceChange(PlayerInput playerInput)
        {
            string currentControlScheme = playerInput.currentControlScheme;
            if (currentControlScheme == keyboardMouseScheme)
                SwitchIcons(0);
            else if (currentControlScheme == ps4Scheme)
                SwitchIcons(1);
            else if (currentControlScheme == xboxScheme)
                SwitchIcons(2);
        }

        private void SwitchIcons(int switchTo)
        {
            foreach (IconSwitch currSwitch in Switches)
            {
                foreach (SpriteRenderer currSprite in currSwitch.SwitchableIcons)
                {
                
                    currSprite.sprite = currSwitch.DeviceIcons[switchTo];
                }

                foreach (Image currImage in currSwitch.SwitchableUIImages)
                {
                    currImage.sprite = currSwitch.DeviceIcons[switchTo];
                }
            }
        }
    }
}