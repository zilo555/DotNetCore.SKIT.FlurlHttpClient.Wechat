using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 TRANSACTION.SUCCESS （仅限直连商户）通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012286313 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012289459 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791836 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791861 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791882 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791902 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013070368 ]]>
    /// </para>
    /// </summary>
    public class TransactionResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class Payer : Models.GetPayTransactionByOutTradeNumberResponse.Types.Payer
            {
            }

            public class Amount : Models.GetPayTransactionByOutTradeNumberResponse.Types.Amount
            {
            }

            public class Scene : Models.GetPayTransactionByOutTradeNumberResponse.Types.Scene
            {
            }

            public class Promotion : Models.GetPayTransactionByOutTradeNumberResponse.Types.Promotion
            {
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_state")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_state")]
        public string TradeState { get; set; } = default!;

        /// <summary>
        /// 获取或设置交易状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_state_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_state_desc")]
        public string TradeStateDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string? BankType { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置支付完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = default!;

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = default!;

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene? Scene { get; set; }

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        public Types.Promotion[]? PromotionList { get; set; }
    }
}
