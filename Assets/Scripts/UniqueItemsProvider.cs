using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "Items", menuName = "Items", order = 0)]
    public class UniqueItemsProvider : ScriptableObject
    {
        #region PUBLIC FIELDS

        [Header("Provided Items")]
        public List<int> items = new List<int>() //This can be any type
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };
        
        [Header("Generated Unique Items")]
        public List<int> uniqueItems = new List<int>(); //This can be any type

        [Header("Iteration")]        
        public int iterationCount;

        #endregion

        #region PRIVATE FIELDS

        private RandomUniqueCollectionInitiliazer<int> _allItems;

        #endregion

        #region UNITY METHODS

        private void OnEnable()
        {
            uniqueItems.Clear();
        }

        #endregion

        #region PUBLIC METHODS

        public void Generate()
        {
            _allItems = new RandomUniqueCollectionInitiliazer<int>(items);
            
            foreach (var item in _allItems.GetUniqueRandomItems(iterationCount))
            {
                Debug.Log($"<color=green>{item}</color>");
                uniqueItems.Add(item);
            }
        }

        #endregion
    }
}