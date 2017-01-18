using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Common
{
    /// <summary>
    /// Json数据帮助类
    /// </summary>
    public class JsonHelper
    {
        /// <summary>
        /// 返回JSON字符串
        /// </summary>
        /// <param name="status">状态</param>
        /// <param name="msg">消息</param>
        /// <returns></returns>
        public static object JsonResult(bool status, string msg)
        {
            return JsonResult(status, msg, "");
        }

        /// <summary>
        /// 返回JSON字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="status">状态</param>
        /// <param name="msg">消息</param>
        /// <param name="data">内容</param>
        /// <returns></returns>
        public static object JsonResult<T>(bool status, string msg, T data)
        {
            var result = new { status= status ? "y" : "n", info = msg, data = data };
            //return SerializerHelper.ToJson(result);
            return result;
        }
    }

    /// <summary>
    /// 序列化帮助类
    /// </summary>
    public static class SerializerHelper
    {
        /// <summary>
        /// 序列化为JSON字符串
        /// </summary>
        /// <param name="entity"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ToJson<T>(T entity)
        {
            var converter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            var serializer = new JsonSerializer();
            serializer.Converters.Add(converter);
            //serializer.ContractResolver = new CamelCasePropertyNamesContractResolver(); //设置属性名称格式为驼峰命名法

            var sb = new StringBuilder();
            serializer.Serialize(new JsonTextWriter(new StringWriter(sb)), entity, typeof(T));
            return sb.ToString();
        }

        /// <summary>
        /// 反序列化JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T FromJson<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// 序列化为XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToXml<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new MemoryStream())
            {
                serializer.Serialize(stream, obj);
                stream.Position = 0;
                var reader = new StreamReader(stream);
                var xml = reader.ReadToEnd();
                reader.Close();
                return xml;
            }
        }

        /// <summary>
        /// 反序列化XML
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T FromXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stream = new MemoryStream())
            {
                var writer = new StreamWriter(stream);
                writer.Write(xml);
                writer.Flush();
                stream.Position = 0;
                var instance = (T)serializer.Deserialize(stream);
                writer.Close();
                return instance;
            }
        }
    }
}
