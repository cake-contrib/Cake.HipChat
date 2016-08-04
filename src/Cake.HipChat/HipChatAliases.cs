using System;
using Cake.Core;
using Cake.Core.Annotations;
using HipChat;

namespace Cake.HipChat
{
    /// <summary>
    /// <para>Exposes functionality in the HipChat.Net NuGet package as a Cake Addin.</para>
    /// <para>
    /// In order to use the commands for this addin, include the following in your build.cake file to download and
    /// reference from NuGet.org:
    /// <code>
    /// #addin Cake.HipChat
    /// </code>
    /// </para>
    /// </summary>
    [CakeAliasCategory("HipChat")]
    public static class HipChatAliases
    {
        ///  <summary>
        ///  Send a HipChat message using the HipChat.Net NuGet Package
        ///  </summary>
        ///  <param name="context">The Cake Context</param>
        ///  <param name="senderName"></param>
        ///  <param name="message">The message to send.</param>
        ///  <param name="authToken"></param>
        ///  <param name="roomId"></param>
        /// <example>
        ///  <code>
        ///      var authToken        = EnvironmentVariable("HIPCHAT_AUTH_TOKEN");
        ///      var roomId = EnvironmentVariable("HIPCHAT_ROOM_ID");
        ///      var senderName = EnvironmentVariable("HIPCHAT_SENDER_NAME");
        /// 
        ///      SendMessage(authToken, roomId, senderName, "Testing, 3, 2, 1");
        ///  </code>
        ///  </example>
        [CakeMethodAlias]
        [CakeNamespaceImportAttribute("Cake.HipChat")]
        public static void SendMessage(this ICakeContext context, string authToken, string roomId, string senderName, string message)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var client = new HipChatClient(authToken, roomId, senderName);

            client.SendMessage(message);
        }
    }
}
