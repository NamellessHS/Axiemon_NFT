using System.Collections.Generic;
using UnityEngine;
using Axiemon.Data;
using Axiemon.Network;

namespace Axiemon.UI
{
    public class AxieSelectionUI : MonoBehaviour
    {
        [Header("Referências")]
        public AxieGraphQLClient client;
        public Transform container; // Onde os cartões serão colocados (ex: um Grid Layout Group)
        public GameObject axiePrefab; // O modelo do cartão que criamos

        [Header("Estado")]
        public List<AxieUIItem> spawnedItems = new List<AxieUIItem>();

        private void Start()
        {
            // Se o client não for atribuído, tenta achar no objeto
            if (client == null)
                client = FindFirstObjectByType<AxieGraphQLClient>();
        }

        // Método que será chamado quando os Axies forem carregados
        public void DisplayAxies(AxieList axieList)
        {
            ClearList();

            if (axieList.results == null) return;

            foreach (var axieData in axieList.results)
            {
                GameObject go = Instantiate(axiePrefab, container);
                AxieUIItem item = go.GetComponent<AxieUIItem>();
                
                if (item != null)
                {
                    item.Setup(axieData);
                    spawnedItems.Add(item);
                }
            }
            
            Debug.Log("<color=cyan>Axiemon UI:</color> Interface atualizada com " + axieList.results.Count + " Axies.");
        }

        public void ClearList()
        {
            foreach (var item in spawnedItems)
            {
                if (item != null) Destroy(item.gameObject);
            }
            spawnedItems.Clear();
        }
    }
}
