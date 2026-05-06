using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using Axiemon.Data;

namespace Axiemon.Network
{
    public class AxieGraphQLClient : MonoBehaviour
    {
        // Endpoint específico para Axies conforme o seu print e a documentação
        private const string API_URL = "https://api-gateway.skymavis.com/graphql/axie-marketplace";
        
        [Header("Autenticação Sky Mavis")]
        public string apiKey = "INSIRA_SUA_CHAVE_AQUI";

        public delegate void OnAxieListLoaded(AxieList axieList);
        public delegate void OnRequestError(string error);

        public void GetAxiesByOwner(string roninAddress, OnAxieListLoaded successCallback, OnRequestError errorCallback)
        {
            // A API exige o formato 0x (42 caracteres)
            string cleanAddress = roninAddress.Trim().ToLower();
            if (cleanAddress.StartsWith("ronin:"))
            {
                cleanAddress = "0x" + cleanAddress.Substring(6);
            }

            // Query otimizada para o novo Gateway
            string query = @"
            {
                ""operationName"": ""GetAxieBriefList"",
                ""variables"": {
                    ""from"": 0,
                    ""size"": 24,
                    ""sort"": ""IdDesc"",
                    ""owner"": """ + cleanAddress + @""",
                    ""criteria"": {}
                },
                ""query"": ""query GetAxieBriefList($from: Int, $size: Int, $sort: SortBy, $owner: String, $criteria: AxieSearchCriteria) { axies(from: $from, size: $size, sort: $sort, owner: $owner, criteria: $criteria) { total results { id name image class parts { id name class type specialGenes } } } }""
            }";

            StartCoroutine(SendRequest(query, successCallback, errorCallback));
        }

        private IEnumerator SendRequest(string jsonData, OnAxieListLoaded successCallback, OnRequestError errorCallback)
        {
            using (UnityWebRequest request = new UnityWebRequest(API_URL, "POST"))
            {
                byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonData);
                request.uploadHandler = new UploadHandlerRaw(bodyRaw);
                request.downloadHandler = new DownloadHandlerBuffer();
                
                // Cabeçalhos obrigatórios para o API Gateway
                request.SetRequestHeader("Content-Type", "application/json");
                request.SetRequestHeader("x-api-key", apiKey);

                yield return request.SendWebRequest();

                if (request.result == UnityWebRequest.Result.Success)
                {
                    string rawJson = request.downloadHandler.text;
                    try
                    {
                        GraphQLResponse response = JsonUtility.FromJson<GraphQLResponse>(rawJson);
                        if (response?.data?.axies != null)
                        {
                            successCallback?.Invoke(response.data.axies);
                        }
                        else
                        {
                            errorCallback?.Invoke("Dados vazios ou erro no formato. Resposta: " + rawJson);
                        }
                    }
                    catch (System.Exception e)
                    {
                        errorCallback?.Invoke("Erro de Processamento: " + e.Message);
                    }
                }
                else
                {
                    string errorBody = request.downloadHandler.text;
                    errorCallback?.Invoke($"Erro {request.responseCode}: {request.error}\nDetalhes: {errorBody}");
                }
            }
        }
    }
}
