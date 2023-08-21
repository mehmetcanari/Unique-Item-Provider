using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class MonoExecution : MonoBehaviour
    {
        #region PUBLIC FIELDS

        public UniqueItemsProvider uniqueItemsProvider;

        #endregion

        #region UNITY METHODS

        private void Start()
        {
            uniqueItemsProvider.Generate();
        }

        #endregion
    }
}