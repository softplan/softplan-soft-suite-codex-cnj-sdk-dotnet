#nullable enable

namespace Softplan.Soft.Suite.Codex.Cnj.Sdk
{
    public partial interface IMtdClient
    {
        /// <summary>
        /// Consulta a auditoria MTD de protocolos de um processo<br/>
        /// Consulta a auditoria MTD de protocolos de um processo
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="protocolo"></param>
        /// <param name="searchAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.CustomSearchAfterResponseAuditoriaMTDProtocolo> RecuperarAuditoriaDeProtocolosDeProcessoAsync(
            string? numeroProcesso = default,
            string? protocolo = default,
            string? searchAfter = default,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Consulta a auditoria MTD de protocolos de um processo<br/>
        /// Consulta a auditoria MTD de protocolos de um processo
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="protocolo"></param>
        /// <param name="searchAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.CustomSearchAfterResponseAuditoriaMTDProtocolo>> RecuperarAuditoriaDeProtocolosDeProcessoAsResponseAsync(
            string? numeroProcesso = default,
            string? protocolo = default,
            string? searchAfter = default,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}