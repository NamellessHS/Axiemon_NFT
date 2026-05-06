using UnityEngine;
using Axiemon.Data;
using Axiemon.Network;

namespace Axiemon.Testing
{
    public class WalletTester : MonoBehaviour
    {
        [Header("Configurações")]
        public string walletAddress = "0xb0891c4de089e61432d05fe6a8ba6844ad6e5846";
        public AxieGraphQLClient client;
        public Axiemon.UI.AxieSelectionUI selectionUI;

        [Header("Resultado (Apenas Visualização)")]
        [SerializeField] private AxieList currentAxies;

        private void Start()
        {
            if (client == null)
                client = GetComponent<AxieGraphQLClient>();

            if (selectionUI == null)
                selectionUI = FindFirstObjectByType<Axiemon.UI.AxieSelectionUI>();

            if (client != null)
            {
                Debug.Log("<color=cyan>Axiemon:</color> Iniciando busca de Axies para a carteira: " + walletAddress);
                client.GetAxiesByOwner(walletAddress, OnSuccess, OnError);
            }
            else
            {
                Debug.LogError("<color=red>Axiemon:</color> AxieGraphQLClient não encontrado!");
            }
        }

        private void OnSuccess(AxieList axieList)
        {
            currentAxies = axieList;
            Debug.Log($"<color=green>Axiemon:</color> Sucesso! Encontrados {axieList.total} Axies.");

            // Atualiza a Interface de Seleção
            if (selectionUI != null)
            {
                selectionUI.DisplayAxies(axieList);
            }

            if (axieList.results == null || axieList.results.Count == 0)
            {
                Debug.LogWarning("<color=orange>Axiemon:</color> A lista de resultados está vazia.");
                return;
            }

            foreach (var axie in axieList.results)
            {
                Debug.Log($"- <b>{axie.name}</b> (ID: {axie.id}) | Classe: {axie.@class}");
                foreach (var part in axie.parts)
                {
                    Debug.Log($"   • Part: {part.name} ({part.type})");
                }
            }
        }

        private void OnError(string error)
        {
            Debug.LogError("<color=red>Axiemon:</color> Erro na requisição: " + error);
        }
    }
}
