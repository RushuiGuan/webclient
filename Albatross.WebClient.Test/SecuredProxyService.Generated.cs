using System.Net.Http;
using System.Text.Json;

namespace Albatross.WebClient.Test {
	public partial class SecuredProxyService : Albatross.WebClient.ClientBase {
		public SecuredProxyService(Microsoft.Extensions.Logging.ILogger<SecuredProxyService> @logger, System.Net.Http.HttpClient @client, JsonSerializerOptions serializationOptions) : base(@logger, @client, serializationOptions) {
		}
		public const System.String ControllerPath = "/api/secured";
		public async System.Threading.Tasks.Task<PayLoad> GetJson() {
			string path = $"{ControllerPath}/json";
			var queryString = new System.Collections.Specialized.NameValueCollection();
			using (var request = this.CreateRequest(HttpMethod.Get, path, queryString)) {
				return await this.GetJsonResponse<PayLoad>(request);
			}
		}
		public async System.Threading.Tasks.Task<System.String> GetText() {
			string path = $"{ControllerPath}/text";
			var queryString = new System.Collections.Specialized.NameValueCollection();
			using (var request = this.CreateRequest(HttpMethod.Get, path, queryString)) {
				return await this.GetJsonResponse<System.String>(request);
			}
		}
		public async System.Threading.Tasks.Task<PayLoad> Post(PayLoad @payLoad) {
			string path = $"{ControllerPath}/post";
			var queryString = new System.Collections.Specialized.NameValueCollection();
			using (var request = this.CreateJsonRequest<PayLoad>(HttpMethod.Post, path, queryString, @payLoad)) {
				return await this.GetJsonResponse<PayLoad>(request);
			}
		}
	}
}
