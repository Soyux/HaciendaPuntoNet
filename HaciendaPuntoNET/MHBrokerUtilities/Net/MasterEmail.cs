using MHBrokerUtilities.Contracts;
using MimeKit;
using System.Net;
using MailKit.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHBrokerUtilities.Net
{
    public class MasterEmail : IMasterEmail,IDisposable
    {
        private bool disposedValue;

        MailKit.Net.Imap.IImapClient imap;

        

        public async Task<bool> ConnectIMAP(string host, int port, string user, string pass, bool ssl)
        {
            imap = (imap ?? new MailKit.Net.Imap.ImapClient());

            await imap.ConnectAsync(host, port, ssl);
            await imap.AuthenticateAsync(new NetworkCredential(user,pass));
            return imap.IsConnected;  
        }

        public async void Disconnect()
        {
            await imap.DisconnectAsync(true);
        }

        public Task<List<MimeMessage>> GetAllMailsAsync(string mailbox = "Mailbox")
        {
             imap.GetFolder(mail)
        }

        public Task<List<MimeMessage>> GetMailsStartIndex(int index, string mailbox = "Mailbox")
        {
            throw new NotImplementedException();
        }

        public List<string> GetMailsWithAttachments(string output, string mailbox = "Inbox", int totalfetch = 200, bool withFilter = false, string pattern = "")
        {
            throw new NotImplementedException();
        }

        public void SendEmail(string host, int port, string user, bool ssl, string dest, string subject, string contenido, List<string> adjuntos = null)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~MasterEmail()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
