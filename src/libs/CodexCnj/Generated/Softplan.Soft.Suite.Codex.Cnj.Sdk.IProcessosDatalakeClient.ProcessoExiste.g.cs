#nullable enable

namespace Softplan.Soft.Suite.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeClient
    {
        /// <summary>
        /// Indica se o processo existe<br/>
        /// Indica se o processo existe
        /// </summary>
        /// <param name="cpfCnpj"></param>
        /// <param name="jtr"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> ProcessoExisteAsync(
            string numeroProcesso,
            string? cpfCnpj = default,
            string? jtr = default,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Indica se o processo existe<br/>
        /// Indica se o processo existe
        /// </summary>
        /// <param name="cpfCnpj"></param>
        /// <param name="jtr"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKHttpResponse<bool>> ProcessoExisteAsResponseAsync(
            string numeroProcesso,
            string? cpfCnpj = default,
            string? jtr = default,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}