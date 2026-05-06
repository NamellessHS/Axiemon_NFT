using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
using Axiemon.Data;

namespace Axiemon.UI
{
    public class AxieUIItem : MonoBehaviour
    {
        [Header("Referências de UI")]
        public Image axieImage;
        public TextMeshProUGUI nameText;
        public TextMeshProUGUI classText;
        public TextMeshProUGUI idText;
        public Image classIcon; // Opcional para o futuro

        private Axie currentData;

        public void Setup(Axie data)
        {
            currentData = data;
            nameText.text = data.name;
            classText.text = data.@class;
            idText.text = "#" + data.id;

            // Iniciar o download da imagem
            if (!string.IsNullOrEmpty(data.image))
            {
                StartCoroutine(DownloadImage(data.image));
            }
        }

        private IEnumerator DownloadImage(string url)
        {
            // O padrão oficial documentado pela Sky Mavis é:
            // https://axiecdn.axieinfinity.com/axies/{id}/axie/axie-full.png
            string officialUrl = $"https://axiecdn.axieinfinity.com/axies/{currentData.id}/axie/axie-full.png";
            
            // Vamos tentar primeiro o oficial, e depois o que veio na API como backup
            string[] urlsToTry = { officialUrl, url };

            foreach (string targetUrl in urlsToTry)
            {
                if (string.IsNullOrEmpty(targetUrl)) continue;

                yield return new WaitForSeconds(Random.Range(0.05f, 0.2f));

                using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(targetUrl))
                {
                    // Baseado na documentação de Metadata e Ronin Market Partner:
                    // Vamos enviar a API Key também na imagem, caso o CDN esteja atrás do Gateway.
                    request.SetRequestHeader("x-api-key", "EWrL72Lgq0JarHxQYdbAZlMA9yobM8X6");
                    request.SetRequestHeader("User-Agent", "SkyMavis/1.0 (Unity; RoninMarketPartner)");
                    request.SetRequestHeader("Referer", "https://docs.skymavis.com/");
                    request.SetRequestHeader("Accept", "*/*");

                    yield return request.SendWebRequest();

                    if (request.result == UnityWebRequest.Result.Success)
                    {
                        Texture2D texture = DownloadHandlerTexture.GetContent(request);
                        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
                        axieImage.sprite = sprite;
                        axieImage.color = Color.white;
                        yield break; // Sucesso! Sai da função
                    }
                    else
                    {
                        Debug.LogWarning($"Tentativa falhou para {targetUrl}: {request.error}");
                    }
                }
            }
            
            Debug.LogError($"<color=red>Axiemon:</color> Não foi possível carregar a imagem do Axie {currentData.id} em nenhuma das URLs.");
        }

        public void OnSelect()
        {
            Debug.Log($"<color=yellow>Axiemon:</color> Você selecionou {currentData.name}!");
            // Aqui adicionaremos a lógica para "spawnar" o Axie no mundo 3D depois
        }
    }
}
