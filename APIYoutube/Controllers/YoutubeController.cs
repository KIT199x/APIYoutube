using APIYoutube.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APIYoutube.Controllers
{
    [ApiController]
    [Route("api/youtube")]
    public class YoutubeController : ControllerBase
    {
        [HttpGet]
        [Route("channel")]
        public ResultAPI channel(string Url, string PlayListId)
        {
            ResultAPI result = new ResultAPI();
            try
            {
                var API_KEY = "AIzaSyDFmdINQSotkRjRobKgyt4FVl-cY9d2VoE";
                var IdChannel = Url.Split('/')[4];
                if (IdChannel.Substring(0, 2) != "UC")
                {
                    result.Message = "Link kênh không được hỗ trợ lấy thông tin";
                    result.StatusCode = 400;
                    result.Channel = null;
                    result.Videos = null;
                    return result;
                }
                else
                {
                    HttpWebRequest request1 = (HttpWebRequest)HttpWebRequest.Create("https://www.googleapis.com/youtube/v3/search?key="+ API_KEY + "&channelId=" + IdChannel + "&part=snippet,id&order=date&maxResults=2222");
                    request1.Method = "GET";
                    String responseJson1 = String.Empty;
                    using (HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse())
                    {
                        Stream dataStream1 = response1.GetResponseStream();
                        StreamReader reader1 = new StreamReader(dataStream1);
                        responseJson1 = reader1.ReadToEnd();
                        reader1.Close();
                        dataStream1.Close();
                    }
                    var result1 = JsonConvert.DeserializeObject<Videos1>(responseJson1);
                    HttpWebRequest request2 = (HttpWebRequest)HttpWebRequest.Create("https://www.googleapis.com/youtube/v3/playlistItems?part=snippet%2CcontentDetails&maxResults=50&playlistId="+PlayListId+"&key=AIzaSyDFmdINQSotkRjRobKgyt4FVl-cY9d2VoE");
                    request2.Method = "GET";
                    String responseJson2 = String.Empty;
                    using (HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse())
                    {
                        Stream dataStream2 = response2.GetResponseStream();
                        StreamReader reader2 = new StreamReader(dataStream2);
                        responseJson2 = reader2.ReadToEnd();
                        reader2.Close();
                        dataStream2.Close();
                    }
                    var result2 = JsonConvert.DeserializeObject<Videos2>(responseJson2);
                    result.StatusCode = 200;
                    result.Message = "Lấy thông tin thành công";
                    result.Channel = result1;
                    result.Videos = result2;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.StatusCode = 400;
                result.Channel = null;
                result.Videos = null;
                return result;
            }
        }
    }
}
