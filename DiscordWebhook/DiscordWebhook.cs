using System;
using System.IO;
using System.Net;
using System.Text;

namespace Discord.Webhook
{
    public class DiscordWebhook
    {
        /// <summary>
        /// Url that can be used for all webhook requests
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Username that will be associated with the message
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Sends discord message using webhook url and username
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
