using RestSharp.Authenticators;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    internal class ConexionAPI
    {
        RestRequest request;
        RestClient client = new RestClient("https://fakestoreapi.com/products");
        public RestResponse Get(string product)
        {
            request = new RestRequest(product,Method.Get);
        }
    }
}
