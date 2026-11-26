#nullable enable

namespace Softplan.Soft.Suite.Codex.Cnj.Sdk
{
    public partial interface ICompetenciasCodexClient
    {
        /// <summary>
        /// Esse endpoint recupera lista de orgão julgador local a partir dos atributos id do orgão de justiça, instância e id da jurisdição local<br/>
        /// Esse endpoint recupera lista de orgão julgador local a partir dos atributos id do orgão de justiça, instância e id da jurisdição local. Proxy do endpoint do serviço Codex: /rest/orgaoJulgadorLocal/recuperar/{orgaoJusticaId}/{instancia}/{jurisdicaoLocaId}
        /// </summary>
        /// <param name="instancia"></param>
        /// <param name="jurisdicaoLocaId"></param>
        /// <param name="orgaoJusticaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConsultarOrgaoJulgadorLocal1Async(
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ConsultarOrgaoJulgadorLocal1Instancia instancia,
            string jurisdicaoLocaId,
            string orgaoJusticaId,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Esse endpoint recupera lista de orgão julgador local a partir dos atributos id do orgão de justiça, instância e id da jurisdição local<br/>
        /// Esse endpoint recupera lista de orgão julgador local a partir dos atributos id do orgão de justiça, instância e id da jurisdição local. Proxy do endpoint do serviço Codex: /rest/orgaoJulgadorLocal/recuperar/{orgaoJusticaId}/{instancia}/{jurisdicaoLocaId}
        /// </summary>
        /// <param name="instancia"></param>
        /// <param name="jurisdicaoLocaId"></param>
        /// <param name="orgaoJusticaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ConsultarOrgaoJulgadorLocal1AsResponseAsync(
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.ConsultarOrgaoJulgadorLocal1Instancia instancia,
            string jurisdicaoLocaId,
            string orgaoJusticaId,
            global::Softplan.Soft.Suite.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}