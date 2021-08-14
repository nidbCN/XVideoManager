using System.IO;

namespace XVideoManager.Core.Utils
{
    public static class FileUtil
    {
        /// <summary>
        /// 获取文件大小
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <returns>文件大小（如果文件不存在则为null）</returns>
        public static uint? GetSize(string fileName)
        {
            var file = new FileInfo(fileName);
            
            if(file.Exists)
                return (uint)file.Length;

            return null;
        }
    }
}
