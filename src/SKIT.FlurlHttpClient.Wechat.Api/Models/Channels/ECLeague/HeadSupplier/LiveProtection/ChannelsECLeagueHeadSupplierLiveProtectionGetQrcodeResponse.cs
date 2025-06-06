namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/liveprotection/getqrcode 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierLiveProtectionGetQrcodeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置二维码 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode_url")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode_url")]
        public string QrcodeUrl { get; set; } = default!;
    }
}
