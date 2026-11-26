#nullable enable

namespace Softplan.Soft.Suite.Codex.Cnj.Sdk
{
    public partial interface IAuditoriaClient
    {
        /// <summary>
        /// Consultar Auditoria Agregada
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="dataHoraConclusao"></param>
        /// <param name="dataHoraInicio"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AuditoriaAgrupadoDTO> ConsultarAuditoriaAgrupadaAsync(
            string clientId,
            string dataHoraConclusao,
            string dataHoraInicio,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Consultar Auditoria Agregada
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="dataHoraConclusao"></param>
        /// <param name="dataHoraInicio"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AuditoriaAgrupadoDTO>> ConsultarAuditoriaAgrupadaAsResponseAsync(
            string clientId,
            string dataHoraConclusao,
            string dataHoraInicio,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}