/*
 * Created by SharpDevelop.
 * User: FSTAR
 * Date: 3/7/2025
 * Time: 1:40 AM
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Quackrsms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

	    private async void Btn_refreshClick(object sender, EventArgs e)
	    {
	    	using (HttpClient client = new HttpClient())
	        {
	            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
	    		client.DefaultRequestHeaders.Add("x-api-key", "YourAPIKEY");
	            string url = "https://api.quackr.io/receive-sms?phoneNumber=YourNumber";

	            try
	            {
	                HttpResponseMessage response = await client.GetAsync(url);
	                if (response.IsSuccessStatusCode)
	                {
	                    string responseData = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(responseData);

	                    // Process the response data and update the UI accordingly
	                    if (json["success"] != null && json["success"].Value<bool>())
	                    {
	                        var messages = json["data"]["messages"];
	                        if (messages != null)
	                        {
	                            string formattedMessages = "";
	                            foreach (var msg in messages)
	                            {
									long recTimestamp = long.Parse(msg["received"].ToString());
	                            	DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds(recTimestamp).DateTime;
	                            	string formattedDate = dateTime.ToString("yyyy-M-d H:m:s");
									formattedMessages += msg["sender"] + ": " + msg["message"] + Environment.NewLine ;
									formattedMessages += "Time: " + formattedDate + Environment.NewLine + Environment.NewLine;
	                            }
	                            txt_sms.Text = formattedMessages.Trim();
	                        }
	                        else
	                        {
	                            txt_sms.Text = "No messages found.";
	                        }
	                    }
	                    else
	                    {
	                        txt_sms.Text = "API returned failure.";
	                    }
	                }
	                else
	                {
						txt_sms.Text = "Failed to retrieve SMS data. Status Code:" + response.StatusCode;
	                }

	            }
	            catch (HttpRequestException ex)
	            {
	                txt_sms.Text = "Request error: " + ex.Message;
	            }
	            catch (Exception ex)
	            {
	                txt_sms.Text = "Unexpected error: " + ex.Message;
	            }
	        }
	    }

	}
}
