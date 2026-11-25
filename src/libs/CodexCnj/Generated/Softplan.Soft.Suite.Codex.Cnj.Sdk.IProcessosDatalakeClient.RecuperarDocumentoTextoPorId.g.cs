#nullable enable

namespace Softplan.Soft.Suite.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeClient
    {
        /// <summary>
        /// Busca documentos textual do processo pelo idProcesso ou numeroProcesso e pelo idDocumento<br/>
        /// Busca documentos textual do processo pelo idProcesso ou numeroProcesso e pelo idDocumento
        /// </summary>
        /// <param name="idDocumento"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RecuperarDocumentoTextoPorIdAsync(
            string idDocumento,
            string numeroProcesso,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Busca documentos textual do processo pelo idProcesso ou numeroProcesso e pelo idDocumento<br/>
        /// Busca documentos textual do processo pelo idProcesso ou numeroProcesso e pelo idDocumento
        /// </summary>
        /// <param name="idDocumento"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> RecuperarDocumentoTextoPorIdAsResponseAsync(
            string idDocumento,
            string numeroProcesso,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}