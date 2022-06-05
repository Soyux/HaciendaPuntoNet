using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;

namespace MHBrokerUtilities.Contracts
{
    public interface IMasterEmail
    {
        public void Disconnect();
        public void SendEmail(string host, int port, string user, bool ssl, string dest, string subject, string contenido,List<string> adjuntos=null);
        public bool ConnectIMAP(string host, int port, string user, string pass, bool ssl);
        public Task<List<MimeKit.MimeMessage>> GetAllMailsAsync(string mailbox = "Mailbox");
        public Task<List<MimeKit.MimeMessage>> GetMailsStartIndex(int index, string mailbox = "Mailbox");

        public List<string> GetMailsWithAttachments(string output, string mailbox = "Inbox", int totalfetch = 200, bool withFilter = false, string pattern = "");
        
        
        

    }//end of interface

}//end of contracts
