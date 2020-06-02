using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Xml;
using System.Xml.Linq;
using Json.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://pgtest.redserfinsa.com:2027/WebPubTransactor/TransactorWS?WSDL");

            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "text/xml");
            request.AddHeader("Host", "pgtest.redserfinsa.com:2027");
            request.AddHeader("User-Agent", "Apache-HttpClient/4.1.1 (java 1.5)");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddParameter("text/xml", "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" " +
                "xmlns:web=\"http://webservices.serfinsa.sysdots.com/\">\n    <soapenv:Header/>\n    <soapenv:Body>\n   " +
                "     <web:cardtransaction>\n            <security>{\"comid\":\"SERVFASANIX\",\"comkey\":\"1234567890\",\"comwrkstation\":\"WORKSFASANI02\"}</security>\n     " +
                "       <txn>MANCOMPRANOR</txn>\n          " +
                "  <message>  \n{\n\t\t\t\t\"CLIENTE_TRANS_TARJETAMAN\":\"9999994570392223\",\n\t\t\t\t\"CLIENTE_TRANS_MONTO\":\"000000000050\",      " +
                "       \"CLIENTE_TRANS_AUDITNO\":\"111127\",       " +
                "    \"CLIENTE_TRANS_TARJETAVEN\":\"2020\",                 " +
                "    \"CLIENTE_TRANS_MODOENTRA\":\"012\",                          " +
                " \"CLIENTE_TRANS_TERMINALID\":\"00299997\",                    " +
                " \"CLIENTE_TRANS_RETAILERID\":\"000999999999999\",          " +
                "   \"CLIENTE_TRANS_RECIBOID\":\"000027\",                     " +
                "      \"CLIENTE_TRANS_TOKENCVV\":\"1611 333\"}              " +
                "     </message>\n        </web:cardtransaction>\n    </soapenv:Body>\n</soapenv:Envelope>", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);


            var s = response.StatusCode;
            txtStatusCode.Text = s.ToString();

                       var content = response.Content;
                XmlDocument xmltest = new XmlDocument();
                xmltest.LoadXml(content);
                XmlNodeList elemlist = xmltest.GetElementsByTagName("return");

                string result = elemlist[0].InnerXml;

                JObject json = JObject.Parse(result);

               



                var SerfinsaStatus = json["cliente_trans_respuesta"];

                if (SerfinsaStatus.ToString() == "00")
                {
                    SerfinsaStatus = "AUTORIZADO";
                }

                else

                {
                    SerfinsaStatus = SerfinsaStatus.ToString();
                }

              


                var NumeroAuth = json["cliente_trans_autoriza"] == null ?0: json["cliente_trans_autoriza"];
                var Amount = json["cliente_trans_monto"] == null ? 0 : json["cliente_trans_monto"];
                var NumRef = json["cliente_trans_referencia"] == null ? 0 : json["cliente_trans_referencia"];


                
                txtserfinsaResp.Text = SerfinsaStatus.ToString();
                txtAuth.Text = NumeroAuth.ToString();
                txtAmount.Text = Amount.ToString();
                txtref.Text = Amount.ToString();



            txtresponse.Text = json.ToString();



            



        }
    }
}
