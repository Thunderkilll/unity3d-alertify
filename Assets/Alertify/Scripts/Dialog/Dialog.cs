﻿using UnityEngine;
using UnityEngine.Events;

namespace Alertify
{
    public sealed class Dialog : MonoBehaviour
	{
        private static Dialog instance;

        //private DialogSettings settings;
        private DialogElement element;

        private void Awake()
        {
			if (instance == null)
			{
				instance = this;

                Init();
			}
			else
			{
				Destroy(gameObject);
			}
        }


        private void Init()
        {
            //settings = Settings.Instance.DialogSettings;
            GameObject prefab = Resources.Load<GameObject>("Prefabs/DialogElement");

            element = Instantiate(prefab, transform).GetComponent<DialogElement>();
        }

        public static void Alert(string dialog, UnityAction ok)
        {
            
        }

        public static void Confirm(string dialog, UnityAction ok, UnityAction cancel)
        {
            
        }

        public static void Prompt(string dialog, UnityAction<string> ok, UnityAction cancel)
        {
            if (instance == null)
            {
                Debug.Log("null");
                return;
            }
            //instance.prompt.Enable(dialog, ok, cancel);
        }

        public static void Prompt(string dialog, UnityAction<string> ok)
        {
            
        }
    }   
}