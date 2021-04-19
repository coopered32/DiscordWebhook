using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.Webhook
{
    public class DiscordWebhook
    {
        /// <summary>
        /// Url that can be used for all future webhook requests
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// User that can be used for all future webhook requests
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Sends discord message using webhook url
        /// </summary>
        /// <param name="message">Message to be sent</param>
        public void SendMessage(string message)
        {
            WebClient wc = new();

            try
            {
                wc.UploadValues(this.Url, new System.Collections.Specialized.NameValueCollection {
                    {
                        "content", message
                    },
                    {
                        "username", this.User
                    }
                });
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
